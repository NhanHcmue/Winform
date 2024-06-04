using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using QL_TiecCuoi.DAO;

namespace WindowsFormsApp1
{
    public partial class DangNhap : KryptonForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string txtNamelogin = "";

        private void cb_hienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            // Sử dụngSystemPasswordChar được thiết lập thành giá trị ngược của Checked
            if (cb_hienthimatkhau.Checked)
            {
                tb_matkhau.PasswordChar = (char)0;
            }
            else
            {
                tb_matkhau.PasswordChar = '●';
            }
        }

        private void kryptonTextBox1_Enter(object sender, EventArgs e)
        {
            KryptonTextBox textBox_tk = (KryptonTextBox)sender;

            if (textBox_tk.Text == "User Name")
            {
                textBox_tk.Text = string.Empty;
            }
        }

        private void tb_matkhau_Enter(object sender, EventArgs e)
        {
            KryptonTextBox  textBox_mk = (KryptonTextBox)sender;

            if (textBox_mk.Text == "Password")
            {
                textBox_mk.Text = string.Empty;
            }
        }

        private void kryptonTextBox1_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox_tk = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox_tk.Text))
            {
                textBox_tk.Text = "User Name";
            }
        }

        private void tb_matkhau_Leave(object sender, EventArgs e)
        {
            KryptonTextBox textBox_mk = (KryptonTextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox_mk.Text))
            {
                textBox_mk.Text = "Password";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string TenDangNhap = tb_taikhoan.Text;
            string MatKhau = tb_matkhau.Text;
            txtNamelogin = tb_taikhoan.Text;
            if (_DangNhap(TenDangNhap, MatKhau))
            {
                this.Hide();
                Form frm = new Form1();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                if (MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }
        bool _DangNhap(string TenDangNhap, string MatKhau)
        {
            return DangNhap_(TenDangNhap, MatKhau);
        }
        public bool DangNhap_(string TenDangNhap, string MatKhau)
        {
            string query = "select * from TaiKhoan where TenDangNhap = '" + TenDangNhap + "' and MatKhau = '" + MatKhau + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        private void tb_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
