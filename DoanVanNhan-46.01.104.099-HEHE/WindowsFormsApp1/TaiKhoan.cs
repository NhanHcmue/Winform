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
using QL_TiecCuoi.DAO;

namespace WindowsFormsApp1
{
    public partial class TaiKhoan : KryptonForm
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            LOAD_FULL_TK();
        }
        private void LOAD_FULL_TK()
        {
            string query = "select * from TaiKhoan";
            DataProvider provider = new DataProvider();
            dataGridViewTKNhanVien.DataSource = provider.ExecuteQuery(query);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (tb_username.Text == "" || tb_password.Text == "" || tb_username.Text == "User Name" || tb_password.Text == "Password")
            {
                if(tb_password.Text == "" || tb_password.Text == "Password") tb_password.Focus();
                if(tb_username.Text == "" || tb_username.Text == "User Name") tb_username.Focus();
                return;
            }
            DataProvider provider = new DataProvider();
            string query = "Insert into TaiKhoan (TenDangNhap, MatKhau) Values(" + "N'"
            + tb_username.Text + "' , '" 
            + tb_password.Text + "')";   
            if(kttaikhoan())
                provider.ExecuteQuery(query);
            LOAD_FULL_TK();
        }

        public bool kttaikhoan()
        {
            string query = "select count(*) as sl from TaiKhoan where TenDangNhap = '" + tb_username.Text + "' and MatKhau = '" + tb_password.Text +"'";
            DataProvider provider = new DataProvider();
            int sl;
            int.TryParse(provider.ExecuteQuery(query).Rows[0]["sl"].ToString(), out sl) ;
            if (sl > 0)
            {
                MessageBox.Show("Đã trùng tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTKNhanVien.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewTKNhanVien.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from TaiKhoan where id='" + a + "'";
                provider.ExecuteQuery(deletedStr);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "select * from TaiKhoan";
                dataGridViewTKNhanVien.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();

                if (dataGridViewTKNhanVien.SelectedCells.Count > 0)
                {
                    int CurrentIndex = dataGridViewTKNhanVien.CurrentCell.RowIndex;
                    string maNhanVien = Convert.ToString(dataGridViewTKNhanVien.Rows[CurrentIndex].Cells[0].Value); // Sửa chỉ mục cột nếu cần thiết
                    string tenTaiKhoan = Convert.ToString(dataGridViewTKNhanVien.Rows[CurrentIndex].Cells[1].Value);
                    string matKhau = Convert.ToString(dataGridViewTKNhanVien.Rows[CurrentIndex].Cells[2].Value);

                    string updateStr = "UPDATE TaiKhoan SET TenDangNhap='" + tenTaiKhoan + "', MatKhau='" + matKhau + "' WHERE Id=" + maNhanVien;
                    Console.Write(updateStr);
                    provider.ExecuteQuery(updateStr);

                    string query = "SELECT * FROM TaiKhoan";
                    dataGridViewTKNhanVien.DataSource = provider.ExecuteQuery(query);
                    MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Chưa chọn dòng để sửa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi, không sửa được. Chi tiết lỗi: " + ex.Message);
            }
            LOAD_FULL_TK();
        }

        private void tb_username_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox_tk = (KryptonTextBox)sender;

            if (textBox_tk.Text == "User Name")
            {
                textBox_tk.Text = string.Empty;
            }
        }

        private void tb_password_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox_tk = (KryptonTextBox)sender;

            if (textBox_tk.Text == "Password")
            {
                textBox_tk.Text = string.Empty;
            }
        }

        private void tb_password_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox_tk = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox_tk.Text))
            {
                textBox_tk.Text = "Password";
            }
        }

        private void tb_username_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox_tk = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox_tk.Text))
            {
                textBox_tk.Text = "User Name";
            }
        }
    }
}
