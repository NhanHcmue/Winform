using QL_TiecCuoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace QL_TiecCuoi
{
    public partial class NhanVien : KryptonForm
    {
        public NhanVien()
        {
            InitializeComponent();
            Show_ComboboxMaNhanVien();
            Show_ComboboxChucVu();
            Show_ComboboxCa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Show_ComboboxMaNhanVien()
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            comboBoxSanh.DisplayMember = "LoaiSanh";
            comboBoxSanh.ValueMember = "LoaiSanh";
            comboBoxSanh.DataSource = provider.ExecuteQuery(query);
        }
        public void Show_ComboboxChucVu()
        {
            string query = "select * from ChucVu";
            DataProvider provider = new DataProvider();
            comboBoxChucVu.DisplayMember = "ChucVu";
            comboBoxChucVu.ValueMember = "ChucVu";
            comboBoxChucVu.DataSource = provider.ExecuteQuery(query);
        }
        public void Show_ComboboxCa()
        {
            string query = "select * from Tiec";
            DataProvider provider = new DataProvider();
            comboBoxCa.DisplayMember = "Ca";
            comboBoxCa.ValueMember = "Ca";
            comboBoxCa.DataSource = provider.ExecuteQuery(query);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            LOAD_FULL_NV();
        }

        private void LOAD_FULL_NV()
        {
            this.Show_ComboboxMaNhanVien();
            this.Show_ComboboxChucVu();
            this.Show_ComboboxCa();
            string query = "select * from NhanVien";
            DataProvider provider = new DataProvider();
            dataGridViewDSNhanVien.DataSource = provider.ExecuteQuery(query);
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxTenNhanVien.Text != "" && textBoxSoDienThoai.Text != "" && textBoxDiaChi.Text != "")
            {
                    DataProvider provider = new DataProvider();
                    string query = "Insert into NhanVien (TenNhanVien, SoDienThoai, DiaChi, LoaiSanh, ChucVu, Ca) Values(" +"N'" 
                    + textBoxTenNhanVien.Text + "' , '"   // TenNhanVien
                    + textBoxSoDienThoai.Text + "' , N'"     //soDienThoai
                    + textBoxDiaChi.Text + "' , N'"   //Dia chi
                    + comboBoxSanh.Text.ToString().Trim() + "' , N'" //Loai Sanh
                    + comboBoxChucVu.SelectedValue.ToString().Trim() + "' , N'"  //Chuc Vu
                    + comboBoxCa.SelectedValue.ToString().Trim()  + "')";  // Ca
                    provider.ExecuteQuery(query);   
                    MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                
            }
            else
                MessageBox.Show("Lỗi, không thêm được");
            LOAD_FULL_NV();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDSNhanVien.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from NhanVien where id='" + a + "'";
                provider.ExecuteQuery(deletedStr);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "select * from NhanVien";
                dataGridViewDSNhanVien.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDSNhanVien.CurrentCell.RowIndex;
                string maNhanVien = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[1].Value.ToString());
                string tenNhanVien = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[2].Value.ToString());
                string soDienThoai = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[3].Value.ToString());
                string diaChi = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[4].Value.ToString());
                string loaiSanh = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[5].Value.ToString());
                string chucVu = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[6].Value.ToString());
                string ca = Convert.ToString(dataGridViewDSNhanVien.Rows[CurrentIndex].Cells[7].Value.ToString());
               
                string updateStr = "Update NhanVien set TenNhanVien='" + tenNhanVien + "',SoDienThoai='" + soDienThoai + "',DiaChi='" + diaChi + "',LoaiSanh = '"+ loaiSanh + "',ChucVu='"+ chucVu + "',Ca='"+ ca +"' where MaNhanVien = '"+ maNhanVien + "'";
                Console.Write(updateStr);
                provider.ExecuteQuery(updateStr);
                
                string query = "select * from NhanVien";
                dataGridViewDSNhanVien.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }

        private void textBoxTenNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void textBoxSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
