using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using QL_TiecCuoi;

namespace WindowsFormsApp1
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            lb_name.Text = "User: ";
            lb_name.Text += DangNhap.txtNamelogin;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ThongTin();
            frm.ShowDialog();
            this.Show();
        }

        private void lậpHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new LapHopDong();
            frm.ShowDialog();
            this.Show();
        }

        private void lậpHóaĐonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new LapHoaDon();
            frm.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new NhanVien();
            frm.ShowDialog();
            this.Show();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_tchoadon.Visible == true)
            {
                menu_tcnhanvien.Visible = false;
                menu_tchopdong.Visible = false;
                menu_tchoadon.Visible = false;
            }
            else
            {
                menu_tcnhanvien.Visible = true;
                menu_tchopdong.Visible = true;
                menu_tchoadon.Visible = true;
            }
        }

        private void menu_tchopdong_Click(object sender, EventArgs e)
        {
            Form frm = new TraCuuHopDong();
            frm.ShowDialog();
            this.Show();
        }

        private void menu_tchoadon_Click(object sender, EventArgs e)
        {
            Form frm = new TraCuuHoaDon();
            frm.ShowDialog();
            this.Show();
        }

        private void menu_tcnhanvien_Click(object sender, EventArgs e)
        {
            Form frm = new TraCuuNhanVien();
            frm.ShowDialog();
            this.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu_lbc.Visible == true)
            {
                menu_lbc.Visible = false;
                menu_bcdt.Visible = false;
            }
            else
            {
                menu_lbc.Visible = true;
                menu_bcdt.Visible = true;
            }
        }

        private void menu_lbc_Click(object sender, EventArgs e)
        {
            Form frm = new LapBaoCao();
            frm.ShowDialog();
            this.Show();
        }

        private void menu_bcdt_Click(object sender, EventArgs e)
        {
            Form frm = new BaoCaoDoanhThu();
            frm.ShowDialog();
            this.Show();
        }

        private void tàiKhoantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TaiKhoan();
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Hide();
                Form frm = new DangNhap();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lb_name_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
