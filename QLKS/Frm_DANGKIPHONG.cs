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
        private int ID_PHONG, SO_PHONG;
        KetNoi kn = new KetNoi();
        public Frm_DANGKIPHONG()
        {
            InitializeComponent();
            
        }
        private void Bang_DANGKYPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("SELECT PHONG.ID,PHONG.TEN,PHONG.TRANG_THAI,LOAI_PHONG.TEN,LOAI_PHONG.SO_NGUOI,LOAI_PHONG.GIA FROM PHONG INNER JOIN LOAI_PHONG ON PHONG.ID_LOAI_PHONG = LOAI_PHONG.ID where TRANG_THAI = 'Trong'");
            DataGrid_Dangkyphong.DataSource = dta;
            HienThi_DuLieu();
        }
        private void Bang_DANG_KY_PHONG()
        {
            
           kn.Lay_DulieuBang("Select * from DANG_KY_PHONG");
            
        }


        public Frm_DANGKIPHONG(int ID_PHONG,int SO_PHONG )
        {
            InitializeComponent();
            this.ID_PHONG = ID_PHONG;
            this.SO_PHONG = SO_PHONG;
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
            numDatphong .Value= ID_PHONG;
            numSophong.DataBindings.Clear();
            numSophong.Value = SO_PHONG;

            DataTable dtaID = kn.Lay_DulieuBang("select MAX(ID) AS ID from DANG_KY_PHONG ");
            
            numID.DataBindings.Add("Value", dtaID, "ID");
            numID.Value = numID.Value + 1;


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            int check = (int)(numSophong.Value - 1);
            if (check <= 0)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Đã đăng ký phòng thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (thongbao == DialogResult.OK) { this.Close(); }
            } else
            {
                numSophong.Value = numSophong.Value - 1;
            }
            string sql_update;
            sql_update = "UPDATE PHONG SET TRANG_THAI='Ban' where ID= " + numPhong.Value;
            kn.ThucThi(sql_update);
                
            string sql_luu;
            sql_luu = "INSERT INTO DANG_KY_PHONG VALUES (" + numID.Text + " , " + numDatphong.Value + ", " + numPhong.Value + ")";
            kn.ThucThi(sql_luu);
                
            Bang_DANGKYPHONG();
            numID.Value = numID.Value + 1;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void numID_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numSophong_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) {
                DataTable dataID = kn.Lay_DulieuBang("select SO_PHONG FROM DAT_PHONG WHERE ID=" + numDatphong.Value);
                numSophong.DataBindings.Clear();
                numSophong.DataBindings.Add("Value", dataID, "SO_PHONG");
                string sql_xoa;
                sql_xoa = "DELETE FROM DANG_KY_PHONG where ID_DAT_PHONG= " + numDatphong.Value;

                string sql_update;
                sql_update = "update PHONG set TRANG_THAI='Trong' where ID IN(select ID_PHONG from DANG_KY_PHONG where ID_DAT_PHONG='" + numDatphong.Value + "')";
                kn.ThucThi(sql_update);
                kn.ThucThi(sql_xoa);
                
            }
            Bang_DANGKYPHONG();

        }

        private void numDatphong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
