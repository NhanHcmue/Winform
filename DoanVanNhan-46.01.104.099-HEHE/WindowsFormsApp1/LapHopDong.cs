using QL_TiecCuoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using System.Web;
using System.Collections;

namespace QL_TiecCuoi
{
    public partial class LapHopDong : KryptonForm
    {
        public LapHopDong()
        {
            InitializeComponent();
            Show_ComboboxTenNhanVien();
            Show_ComboboxLoaiSanh();
            Show_ComboboxCa();
            Show_ComboboxThucDon();
            Show_ComboboxDichVu();
            textBoxSoLuongBan.TextChanged += textBoxSoLuongBan_TextChanged;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form frm = new LapHoaDon();
            frm.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form frm = new LapHopDong();
            frm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxTenKhachHang.Text != "" && textBoxTenChuRe.Text != "" && textBoxTenCoDau.Text != "" && textBoxDienThoai.Text != "" && textBoxDiaChi.Text != "" && textBoxEmail.Text != "" && textBoxTienCoc.Text != "" && textBoxSoLuongBan.Text != "" && textBoxSLNhanVien.Text != "")
            {
                int a;
                bool isAValid = int.TryParse(textBoxTienCoc.Text.Trim(), out a);
                if (a < 10000000)
                {
                    MessageBox.Show("Số tiền cọc phải tối thiểu là 10.000.000 đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (a >= 10000000)
                {

                    int b;
                    bool isAValid_1 = int.TryParse(textBoxSoLuongBan.Text.Trim(), out b);
                    string sCombobox = this.comboBoxLoaiSanh.Text.Normalize();
                    if (comboBoxLoaiSanh.Text.CompareTo("Loai A") == 0)
                    {
                        if (b > 500)
                        {

                            MessageBox.Show("Số lương bàn tối đa là 500 bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (b <= 500)
                        {
                            int c;
                            bool isAValid_2 = int.TryParse(textBoxSLNhanVien.Text.Trim(), out c);
                            if (b != c)
                            {
                                MessageBox.Show("Số lương nhân viên phải bằng số lượng bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (b == c)
                            {
                                /*
                                 * DataProvider provider = new DataProvider();
                                    string formatDate = "MM/dd/yyyy";
                                    string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai, EMail, NgayToChuc, TienCoc) Values('"
                                        + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                                        + textBoxTenKhachHang.Text + "' , '"
                                        + textBoxTenChuRe.Text + "' , '"
                                        + textBoxTenCoDau.Text + "' , '"
                                        + textBoxDiaChi.Text + "' , '"
                                        + textBoxDienThoai.Text + "', '"
                                        + textBoxEmail.Text + "', '"
                                        + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , "
                                        + textBoxTienCoc.Text + ")";
                                    int IDTHONGTINKHACHHANG;
                                    provider.ExecuteQuery(query1);
                                    string query = "SELECT id FROM ThongTinKhachHang WHERE id = (SELECT MAX(id) FROM ThongTinKhachHang);";
                                //    if ()
                                //    {
                                        int.TryParse(provider.ExecuteQuery(query).Rows[0]["ID"].ToString(), out IDTHONGTINKHACHHANG);
                                        string query2 = "Insert into ThongTinDatTiec (IDNhanVien, IDThongTinKhachHang, IdLoaiSanh, IdDichVu, IdThucDon, SoLuongNhanVien, SoLuongBan,Ca) Values("
                                        + comboBoxTenNhanVien.SelectedValue + " , "
                                        + IDTHONGTINKHACHHANG + " , "
                                        + comboBoxLoaiSanh.SelectedValue+ " , "
                                        + comboBoxDichVu.SelectedValue + " , "
                                        + comboBoxThucDon.SelectedValue + " , "
                                        + textBoxSLNhanVien.Text + " , "
                                        + textBoxSoLuongBan.Text + " , '"
                                        + comboBoxCa.Text.ToString().Trim() + "')";
                                        provider.ExecuteQuery(query2);
                                        MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                                 */
                                DataProvider provider = new DataProvider();
                                string formatDate = "MM/dd/yyyy";
                                string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai, EMail, NgayToChuc, TienCoc) Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                                    + textBoxTenKhachHang.Text + "' , '"
                                    + textBoxTenChuRe.Text + "' , '"
                                    + textBoxTenCoDau.Text + "' , '"
                                    + textBoxDiaChi.Text + "' , '"
                                    + textBoxDienThoai.Text + "', '"
                                    + textBoxEmail.Text + "', '"
                                    + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , "
                                    + textBoxTienCoc.Text + ")";
                                if (KtraToChuc())
                                {
                                    int IDTHONGTINKHACHHANG;
                                    provider.ExecuteQuery(query1);
                                    string query = "SELECT id FROM ThongTinKhachHang WHERE id = (SELECT MAX(id) FROM ThongTinKhachHang);";
                                    int.TryParse(provider.ExecuteQuery(query).Rows[0]["ID"].ToString(), out IDTHONGTINKHACHHANG);
                                    string query2 = "Insert into ThongTinDatTiec (IDNhanVien, IDThongTinKhachHang, IdLoaiSanh, IdDichVu, IdThucDon, SoLuongNhanVien, SoLuongBan,Ca) Values("
                                    + comboBoxTenNhanVien.SelectedValue + " , "
                                    + IDTHONGTINKHACHHANG + " , "
                                    + comboBoxLoaiSanh.SelectedValue + " , "
                                    + comboBoxDichVu.SelectedValue + " , "
                                    + comboBoxThucDon.SelectedValue + " , "
                                    + textBoxSLNhanVien.Text + " , "
                                    + textBoxSoLuongBan.Text + " , '"
                                    + comboBoxCa.Text.ToString().Trim() + "')";
                                    provider.ExecuteQuery(query2);
                                    MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    if (comboBoxLoaiSanh.Text.CompareTo("Loai B") == 0)
                    {
                        if (b > 450)
                        {

                            MessageBox.Show("Số lương bàn tối đa là 450 bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (b <= 450)
                        {
                            int c;
                            bool isAValid_2 = int.TryParse(textBoxSLNhanVien.Text.Trim(), out c);
                            if (b != c)
                            {
                                MessageBox.Show("Số lương nhân viên phải bằng số lượng bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (b == c)
                            {
                                DataProvider provider = new DataProvider();
                                string formatDate = "MM/dd/yyyy";
                                string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai, EMail, NgayToChuc, TienCoc) Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                                    + textBoxTenKhachHang.Text + "' , '"
                                    + textBoxTenChuRe.Text + "' , '"
                                    + textBoxTenCoDau.Text + "' , '"
                                    + textBoxDiaChi.Text + "' , '"
                                    + textBoxDienThoai.Text + "', '"
                                    + textBoxEmail.Text + "', '"
                                    + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , "
                                    + textBoxTienCoc.Text + ")";
                                if (KtraToChuc())
                                {
                                    int IDTHONGTINKHACHHANG;
                                    provider.ExecuteQuery(query1);
                                    string query = "SELECT id FROM ThongTinKhachHang WHERE id = (SELECT MAX(id) FROM ThongTinKhachHang);";
                                    int.TryParse(provider.ExecuteQuery(query).Rows[0]["ID"].ToString(), out IDTHONGTINKHACHHANG);
                                    string query2 = "Insert into ThongTinDatTiec (IDNhanVien, IDThongTinKhachHang, IdLoaiSanh, IdDichVu, IdThucDon, SoLuongNhanVien, SoLuongBan,Ca) Values("
                                    + comboBoxTenNhanVien.SelectedValue + " , "
                                    + IDTHONGTINKHACHHANG + " , "
                                    + comboBoxLoaiSanh.SelectedValue + " , "
                                    + comboBoxDichVu.SelectedValue + " , "
                                    + comboBoxThucDon.SelectedValue + " , "
                                    + textBoxSLNhanVien.Text + " , "
                                    + textBoxSoLuongBan.Text + " , '"
                                    + comboBoxCa.Text.ToString().Trim() + "')";
                                    provider.ExecuteQuery(query2);
                                    MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                                }
                            }
                        }

                    }
                    if (comboBoxLoaiSanh.Text.CompareTo("Loai C") == 0)
                    {
                        if (b > 450)
                        {

                            MessageBox.Show("Số lương bàn tối đa là 400 bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (b <= 400)
                        {
                            int c;
                            bool isAValid_2 = int.TryParse(textBoxSLNhanVien.Text.Trim(), out c);
                            if (b != c)
                            {
                                MessageBox.Show("Số lương nhân viên phải bằng số lượng bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (b == c)
                            {
                                DataProvider provider = new DataProvider();
                                string formatDate = "MM/dd/yyyy";
                                string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai, EMail, NgayToChuc, TienCoc) Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                                    + textBoxTenKhachHang.Text + "' , '"
                                    + textBoxTenChuRe.Text + "' , '"
                                    + textBoxTenCoDau.Text + "' , '"
                                    + textBoxDiaChi.Text + "' , '"
                                    + textBoxDienThoai.Text + "', '"
                                    + textBoxEmail.Text + "', '"
                                    + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , "
                                    + textBoxTienCoc.Text + ")";
                                if (KtraToChuc())
                                {
                                    int IDTHONGTINKHACHHANG;
                                    provider.ExecuteQuery(query1);
                                    string query = "SELECT id FROM ThongTinKhachHang WHERE id = (SELECT MAX(id) FROM ThongTinKhachHang);";
                                    int.TryParse(provider.ExecuteQuery(query).Rows[0]["ID"].ToString(), out IDTHONGTINKHACHHANG);
                                    string query2 = "Insert into ThongTinDatTiec (IDNhanVien, IDThongTinKhachHang, IdLoaiSanh, IdDichVu, IdThucDon, SoLuongNhanVien, SoLuongBan,Ca) Values("
                                    + comboBoxTenNhanVien.SelectedValue + " , "
                                    + IDTHONGTINKHACHHANG + " , "
                                    + comboBoxLoaiSanh.SelectedValue + " , "
                                    + comboBoxDichVu.SelectedValue + " , "
                                    + comboBoxThucDon.SelectedValue + " , "
                                    + textBoxSLNhanVien.Text + " , "
                                    + textBoxSoLuongBan.Text + " , '"
                                    + comboBoxCa.Text.ToString().Trim() + "')";
                                    provider.ExecuteQuery(query2);
                                    MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                                }
                            }
                        }

                    }
                    if (comboBoxLoaiSanh.Text.CompareTo("Loai D") == 0)
                    {
                        if (b > 350)
                        {

                            MessageBox.Show("Số lương bàn tối đa là 350 bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (b <= 350)
                        {
                            int c;
                            bool isAValid_2 = int.TryParse(textBoxSLNhanVien.Text.Trim(), out c);
                            if (b != c)
                            {
                                MessageBox.Show("Số lương nhân viên phải bằng số lượng bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (b == c)
                            {
                                DataProvider provider = new DataProvider();
                                string formatDate = "MM/dd/yyyy";
                                string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai, EMail, NgayToChuc, TienCoc) Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                                    + textBoxTenKhachHang.Text + "' , '"
                                    + textBoxTenChuRe.Text + "' , '"
                                    + textBoxTenCoDau.Text + "' , '"
                                    + textBoxDiaChi.Text + "' , '"
                                    + textBoxDienThoai.Text + "', '"
                                    + textBoxEmail.Text + "', '"
                                    + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , "
                                    + textBoxTienCoc.Text + ")";
                                if (KtraToChuc())
                                {
                                    int IDTHONGTINKHACHHANG;
                                    provider.ExecuteQuery(query1);
                                    string query = "SELECT id FROM ThongTinKhachHang WHERE id = (SELECT MAX(id) FROM ThongTinKhachHang);";
                                    int.TryParse(provider.ExecuteQuery(query).Rows[0]["ID"].ToString(), out IDTHONGTINKHACHHANG);
                                    string query2 = "Insert into ThongTinDatTiec (IDNhanVien, IDThongTinKhachHang, IdLoaiSanh, IdDichVu, IdThucDon, SoLuongNhanVien, SoLuongBan,Ca) Values("
                                    + comboBoxTenNhanVien.SelectedValue + " , "
                                    + IDTHONGTINKHACHHANG + " , "
                                    + comboBoxLoaiSanh.SelectedValue + " , "
                                    + comboBoxDichVu.SelectedValue + " , "
                                    + comboBoxThucDon.SelectedValue + " , "
                                    + textBoxSLNhanVien.Text + " , "
                                    + textBoxSoLuongBan.Text + " , '"
                                    + comboBoxCa.Text.ToString().Trim() + "')";
                                    provider.ExecuteQuery(query2);
                                    MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                                }
                            }
                        }


                    }
                    if (comboBoxLoaiSanh.Text.CompareTo("Loai E") == 0)
                    {
                        if (b > 300)
                        {

                            MessageBox.Show("Số lương bàn tối đa là 300 bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else if (b <= 300)
                        {
                            int c;
                            bool isAValid_2 = int.TryParse(textBoxSLNhanVien.Text.Trim(), out c);
                            if (b != c)
                            {
                                MessageBox.Show("Số lương nhân viên phải bằng số lượng bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else if (b == c)
                            {
                                DataProvider provider = new DataProvider();
                                string formatDate = "MM/dd/yyyy";
                                string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai, EMail, NgayToChuc, TienCoc) Values('"
                                    + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                                    + textBoxTenKhachHang.Text + "' , '"
                                    + textBoxTenChuRe.Text + "' , '"
                                    + textBoxTenCoDau.Text + "' , '"
                                    + textBoxDiaChi.Text + "' , '"
                                    + textBoxDienThoai.Text + "', '"
                                    + textBoxEmail.Text + "', '"
                                    + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "' , "
                                    + textBoxTienCoc.Text + ")";
                                if (KtraToChuc())
                                {
                                    int IDTHONGTINKHACHHANG;
                                    provider.ExecuteQuery(query1);
                                    string query = "SELECT id FROM ThongTinKhachHang WHERE id = (SELECT MAX(id) FROM ThongTinKhachHang);";
                                    int.TryParse(provider.ExecuteQuery(query).Rows[0]["ID"].ToString(), out IDTHONGTINKHACHHANG);
                                    string query2 = "Insert into ThongTinDatTiec (IDNhanVien, IDThongTinKhachHang, IdLoaiSanh, IdDichVu, IdThucDon, SoLuongNhanVien, SoLuongBan,Ca) Values("
                                    + comboBoxTenNhanVien.SelectedValue + " , "
                                    + IDTHONGTINKHACHHANG + " , "
                                    + comboBoxLoaiSanh.SelectedValue + " , "
                                    + comboBoxDichVu.SelectedValue + " , "
                                    + comboBoxThucDon.SelectedValue + " , "
                                    + textBoxSLNhanVien.Text + " , "
                                    + textBoxSoLuongBan.Text + " , '"
                                    + comboBoxCa.Text.ToString().Trim() + "')";
                                    provider.ExecuteQuery(query2);
                                    MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                                }

                            }
                        }

                    }

                }


            }
            else
            {
                if (textBoxTenKhachHang.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Họ tên không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxTenChuRe.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Tên chú rể không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxTenCoDau.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Tên cô dâu không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxDiaChi.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Địa chỉ không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxEmail.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Email không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxDienThoai.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Số điện thoại không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxSoLuongBan.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Số lượng bàn không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textBoxSLNhanVien.Text.Trim().CompareTo("") == 0)
                {
                    MessageBox.Show("Số lượng nhân viên không được bỏ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }
        }

        private ToolTip tooltip;

        private void textBoxTienCoc_TextChanged(object sender, EventArgs e)
        {
            int a;
            bool isAValid = int.TryParse(textBoxTienCoc.Text.Trim(), out a);

            if (tooltip == null)
            {
                tooltip = new ToolTip();
            }

            if (a < 10000000)
            {
                tooltip.Show("Tiền cọc tối thiểu là 10.000.000 đồng", textBoxTienCoc, 2000);
            }
        }

        private bool KtraToChuc()
        {
            string formatDate = "MM/dd/yyyy";
            string ngayToChuc = dateTimePickerNgayToChuc.Value.ToString(formatDate);
            string loaiSanh = comboBoxLoaiSanh.SelectedValue.ToString().Trim();
            string ca = comboBoxCa.Text.ToString().Trim();
            string query0 = "select count(*) as count from ThongTinDatTiec a left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang where p.NgayToChuc = '" + ngayToChuc + "' and a.Ca = '" + ca + "' and a.IdLoaiSanh = '" + loaiSanh + "'";
            DataProvider provider = new DataProvider();
            int rowCount;
            int.TryParse(provider.ExecuteQuery(query0).Rows[0]["count"].ToString(), out rowCount);

            if (rowCount > 0)
            {
                MessageBox.Show("Đã có khách đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void Show_ComboboxTenNhanVien()
        {
            string query = "select * from NhanVien where ChucVu = N'Tiếp Tân'";
            DataProvider provider = new DataProvider();
            comboBoxTenNhanVien.DataSource = provider.ExecuteQuery(query);
            comboBoxTenNhanVien.DisplayMember = "TenNhanVien";
            comboBoxTenNhanVien.ValueMember = "id";
        }
        public void Show_ComboboxLoaiSanh()
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            comboBoxLoaiSanh.DataSource = provider.ExecuteQuery(query);
            comboBoxLoaiSanh.DisplayMember = "LoaiSanh";
            comboBoxLoaiSanh.ValueMember = "id";//testing
        }

        public void Show_ComboboxCa()
        {
            string query = "select * from Tiec";
            DataProvider provider = new DataProvider();
            comboBoxCa.DataSource = provider.ExecuteQuery(query);
            comboBoxCa.DisplayMember = "Ca";
            comboBoxCa.ValueMember = "id";//test
        }

        public void Show_ComboboxThucDon()
        {
            string query = "select * from ThucDon";
            DataProvider provider = new DataProvider();
            comboBoxThucDon.DataSource = provider.ExecuteQuery(query);
            comboBoxThucDon.DisplayMember = "MaThucDon";
            comboBoxThucDon.ValueMember = "id";
        }

        public void Show_ComboboxDichVu()
        {
            string query = "select * from DichVu";
            DataProvider provider = new DataProvider();
            comboBoxDichVu.DataSource = provider.ExecuteQuery(query);
            comboBoxDichVu.DisplayMember = "MaDichVu";
            comboBoxDichVu.ValueMember = "id";
        }

      

        private void comboBoxLoaiSanh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void LapHopDong_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBoxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuHopDong();
            frm.ShowDialog();
            this.Show();

        }

        private void textBoxTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        


        }

        private void textBoxTenChuRe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
           
           
        }

        private void textBoxTenCoDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void textBoxDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
           
        }

        private void textBoxTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void textBoxSoLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxSLNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxSoLuongBan_TextChanged(object sender, EventArgs e)
        {
            textBoxSLNhanVien.Text = textBoxSoLuongBan.Text;
        }
    }
}
