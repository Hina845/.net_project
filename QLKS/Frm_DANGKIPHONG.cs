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

namespace QLKS
{
    public partial class Frm_DANGKIPHONG : Form
    {
        private int ID;
        KetNoi kn = new KetNoi();
        public Frm_DANGKIPHONG()
        {
            InitializeComponent();
            
        }
        private void Bang_DANGKYPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("SELECT PHONG.ID,PHONG.TEN,PHONG.TRANG_THAI,LOAI_PHONG.TEN,LOAI_PHONG.SO_NGUOI,LOAI_PHONG.GIA FROM PHONG INNER JOIN LOAI_PHONG ON PHONG.ID_LOAI_PHONG = LOAI_PHONG.ID");
            DataGrid_Dangkyphong.DataSource = dta;
            HienThi_DuLieu();
        }

        public Frm_DANGKIPHONG(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        public void HienThi_DuLieu()
        {
            numPhong.DataBindings.Clear();
            numPhong.DataBindings.Add("Value", DataGrid_Dangkyphong.DataSource, "ID");
        }

            private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIDDatphong_Click(object sender, EventArgs e)
        {

        }

        private void Frm_DANGKIPHONG_Load(object sender, EventArgs e)
        {
            Bang_DANGKYPHONG();
            numDatphong.DataBindings.Clear();
            numDatphong .Value= ID;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Đã đăng ký phòng thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }
    }
}
