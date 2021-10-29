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
    public partial class Frm_DATPHONG : Form
    {
        private int ID;
        public Frm_DATPHONG()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
       
        public Frm_DATPHONG(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void Frm_DATPHONG_Load(object sender, EventArgs e)
        {
            txt_khachang.DataBindings.Clear();
            txt_khachang.Value = ID;
            //chọn ra ID lớn nhất ở bảng DAT_PHONG
            DataTable dtaID = kn.Lay_DulieuBang("select MAX(ID) AS ID from DAT_PHONG ");
            //tự động nhảy ID đặt phòng
            txt_datphong.DataBindings.Add("Value", dtaID, "ID");
            txt_datphong.Value = txt_datphong.Value + 1;

            //combobox Nhanvienthuchien
            txt_nhanvienthuchien.DataSource = kn.Lay_DulieuBang("select ID from NHAN_VIEN where CHUC_VU='Tiep tan';");
            txt_nhanvienthuchien.DisplayMember = "ID";
            txt_nhanvienthuchien.ValueMember = "ID";
        }

        private void btn_chitietdatphong_Click(object sender, EventArgs e)
        {
            decimal a = txt_datphong.Value;
            decimal c = txt_sophong.Value;
            int b = decimal.ToInt32(a);
            int d = decimal.ToInt32(c);

            //them dl vao bang DAT_PHONG
            String sql = "Insert into DAT_PHONG VALUES("+txt_datphong.Value+","+txt_khachang.Value+","+txt_nhanvienthuchien.Text+","+txt_songuoi.Value+","+txt_sophong.Value+",'"+txt_ngaydat.Value+"','"+txt_ngayden.Value+"','"+txt_ngaydi.Value+"')";
            kn.ThucThi(sql);
                
            Frm_DANGKIPHONG frm = new Frm_DANGKIPHONG(b, d);
            frm.Show();
            this.Hide();
        }

 

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_datphong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
