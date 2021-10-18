using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class Frm_DichVu : Form
    {
        public Frm_DichVu()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();

        public void BANG_DICHVU()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from DICH_VU");
            dataGridView1.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txt_ID.DataBindings.Clear();
            txt_ID.DataBindings.Add("Text", dataGridView1.DataSource, "ID");

            txt_TenDV.DataBindings.Clear();
            txt_TenDV.DataBindings.Add("Text", dataGridView1.DataSource, "TEN");

            txt_Gia.DataBindings.Clear();
            txt_Gia.DataBindings.Add("Text", dataGridView1.DataSource, "GIA");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKSDataSet.DICH_VU' table. You can move, or remove it, as needed.
            this.dICH_VUTableAdapter.Fill(this.qLKSDataSet.DICH_VU);
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BANG_DICHVU();
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_TenDV.Text = "";
            txt_Gia.Text = "";
            txt_ID.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            String sql_Luu = "insert into DICH_VU values (" + txt_ID.Text + ",'" + txt_TenDV.Text + "', " + txt_Gia.Text + ");";
            kn.ThucThi(sql_Luu);
            BANG_DICHVU();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql_sua = "update  DICH_VU set TEN = '" + txt_TenDV.Text + "' , GIA=" + txt_Gia.Text + " where ID=" + txt_ID.Text ;
            kn.ThucThi(sql_sua);
            BANG_DICHVU();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            String sql_Xoa = "DELETE  FROM [DICH_VU] WHERE ID=" + txt_ID.Text + ";";
            kn.ThucThi(sql_Xoa);
            BANG_DICHVU();
        }
    }
}
