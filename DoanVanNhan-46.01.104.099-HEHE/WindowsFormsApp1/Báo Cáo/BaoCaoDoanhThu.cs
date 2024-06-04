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
using ComponentFactory.Krypton.Toolkit;


namespace QL_TiecCuoi
{
    public partial class BaoCaoDoanhThu : KryptonForm
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            Load_bcdt();
            load_bcdtt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            Load_bcdt();
        }
        public void load_bcdtt()
        {
            string query = "Select * from BaoCaoDoanhThu";
            DataProvider provider = new DataProvider();
            dataGridViewTongDoanhThu.DataSource = provider.ExecuteQuery(query);
        }
        public void Load_bcdt()
        {
            string query = "Select * from LapBaoCao";
            DataProvider provider = new DataProvider();
            dataGridViewDSBaoCao.DataSource = provider.ExecuteQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string query1 = "Insert into BaoCaoDoanhThu (Thang,TongDoanhThu) Values('"
                + textBoxThang.Text + "' , '"
                + textBoxTongDoanhThu.Text + "')";
            provider.ExecuteQuery(query1);
            MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load_bcdtt();
        }
    }
}
