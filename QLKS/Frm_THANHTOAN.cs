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
    public partial class Frm_THANHTOAN : Form
    {
        // để chạy được mọi người cần insert dữ liệu vào bảng HOA_DON_PHONG, CHI_TIET_SU_DUNG_DV
        private int ID_datphong;
        private int IDphong;
        private int songayo;
        public Frm_THANHTOAN()
        {
            InitializeComponent();
        }
        public Frm_THANHTOAN(int a, int b, int c)
        {
            InitializeComponent();
            this.ID_datphong = a;
            this.IDphong = b;
            this.songayo = c;
        }
        KetNoi kn = new KetNoi();
        private void Frm_THANHTOAN_Load(object sender, EventArgs e)
        {
            //chọn ra ID lớn nhất ở bảng HOA_DON_PHONG
            DataTable dtaID = kn.Lay_DulieuBang("select MAX(ID) AS ID from HOA_DON_PHONG ");
            //tự động nhảy ID đặt phòng
            txt_IDhoadon.DataBindings.Clear();
            txt_IDhoadon.DataBindings.Add("Value", dtaID, "ID");
            txt_IDhoadon.Value = txt_IDhoadon.Value + 1;
            //hiện đơn giá
            DataTable dtaDongia = kn.Lay_DulieuBang("SELECT LP.GIA AS DON_GIA FROM [PHONG] as p INNER JOIN LOAI_PHONG as lp ON p.ID_LOAI_PHONG = lp.ID where p.ID = "+IDphong);
            txt_dongia.DataBindings.Clear();
            txt_dongia.DataBindings.Add("Text", dtaDongia, "DON_GIA");

            //combobox Nhanvienthuchien
            txt_nguoixacnhan.DataSource = kn.Lay_DulieuBang("select ID from NHAN_VIEN where CHUC_VU='Tiep tan';");
            txt_nguoixacnhan.DisplayMember = "ID";
            txt_nguoixacnhan.ValueMember = "ID";

            txt_IDdatphong.Value = ID_datphong;
            txt_IDphong.Value = IDphong;
            txt_songayo.Value = songayo;
            // tienphong = dongia x songayo
            String p = txt_dongia.Text;
            int b = Int32.Parse(p);
            double c = b * songayo; //tiền phòng
            txt_tienphong.DataBindings.Add("Text", c, "");
            //hiển thị dataGridview1
            DataTable dtatiendichvu = kn.Lay_DulieuBang("SELECT ctdv.ID_PHONG , ctdv.ID_DICH_VU,ctdv.NGAY_DUNG,dv.TEN,dv.GIA FROM CHI_TIET_SU_DUNG_DV as ctdv INNER JOIN DICH_VU as dv ON ctdv.ID_DICH_VU=dv.ID where ctdv.ID_PHONG =" + txt_IDphong.Value+";");
            dataGridView1.DataSource = dtatiendichvu;
            //hiển thị tổng tiền dịch vụ
            DataTable dtahienthitiendv = kn.Lay_DulieuBang("SELECT SUM(dv.GIA) as TONG_TIEN_DICH_VU FROM CHI_TIET_SU_DUNG_DV as ctdv INNER JOIN DICH_VU as dv ON ctdv.ID_DICH_VU=dv.ID where ctdv.ID_PHONG=" + txt_IDphong.Value+";");
            txt_tiendichvu.DataBindings.Clear();
            txt_tiendichvu.DataBindings.Add("Text", dtahienthitiendv, "TONG_TIEN_DICH_VU");
            if (txt_tiendichvu.Text != "")
            {
                
                // hiển thị tổng tiền cần phải thanh toán
                String dv = txt_tiendichvu.Text;
                int dv2 = Int32.Parse(dv); //tong tien dich vụ
                double tongtien = dv2 + c;
                lb_hientongtien.DataBindings.Clear();
                lb_hientongtien.DataBindings.Add("Text", tongtien, "");
            }
            else { 
                txt_tiendichvu.Text = "0";
                lb_hientongtien.DataBindings.Clear();
                lb_hientongtien.DataBindings.Add("Text", c, "");
            }
            
            
            
        }

        private void lb_hientongtien_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuathoadon_Click(object sender, EventArgs e)
        {
            String sqlinsert = "insert into [HOA_DON_PHONG] values("+txt_IDhoadon.Value+ ","+txt_nguoixacnhan.Text+ ","+txt_IDphong.Value+ ",'"+txt_lydo.Text+ "',"+lb_hientongtien.Text+ ",'"+txt_ngaythanhtoan.Value+"');";
            MessageBox.Show("Đã xuất hóa đơn");
        }
    }
}
