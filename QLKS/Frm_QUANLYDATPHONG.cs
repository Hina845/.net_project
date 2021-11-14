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
    public partial class Frm_QUANLYDATPHONG : Form
    {
        public Frm_QUANLYDATPHONG()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        public void BANG_QUANLYDATPHONG()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("SELECT dp.ID as ID, dp.ID_KHACH_HANG as ID_KHACH_HANG, dp.ID_NGUOI_THUC_HIEN as ID_NGUOI_THUC_HIEN, dp.SO_NGUOI as SO_NGUOI, dp.SO_PHONG as SO_PHONG, dp.NGAY_DAT as NGAY_DAT, dp.NGAY_DEN as NGAY_DEN, dp.NGAY_DI as NGAY_DI,  dkp.ID_PHONG as ID_Phong FROM DAT_PHONG as dp INNER JOIN DANG_KY_PHONG as dkp ON dp.ID = dkp.ID_DAT_PHONG");
            dataGridView1.DataSource = dta;
            HIENTHI_DULIEU();
        }

        private void HIENTHI_DULIEU()
        {
            txt_khachang.DataBindings.Clear();
            txt_khachang.DataBindings.Add("Value", dataGridView1.DataSource, "ID_KHACH_HANG");

            txt_datphong.DataBindings.Clear();
            txt_datphong.DataBindings.Add("Value", dataGridView1.DataSource, "ID");

            txt_songuoi.DataBindings.Clear();
            txt_songuoi.DataBindings.Add("Value", dataGridView1.DataSource, "SO_NGUOI");

            txt_sophong.DataBindings.Clear();
            txt_sophong.DataBindings.Add("Value", dataGridView1.DataSource, "SO_PHONG");

            txt_ngaydat.DataBindings.Clear();
            txt_ngaydat.DataBindings.Add("Value", dataGridView1.DataSource, "NGAY_DAT");

            txt_ngayden.DataBindings.Clear();
            txt_ngayden.DataBindings.Add("Value", dataGridView1.DataSource, "NGAY_DEN");

            txt_ngaydi.DataBindings.Clear();
            txt_ngaydi.DataBindings.Add("Value", dataGridView1.DataSource, "NGAY_DI");

            txt_nhanvienthuchien.DataBindings.Clear();
            txt_nhanvienthuchien.DataBindings.Add("Text", dataGridView1.DataSource, "ID_NGUOI_THUC_HIEN");

        }

        //
        private void HIENTHI_DULIEU2()
        {
           
            // hiển thị cho phần tìm kiếm
            txt_datphong.DataBindings.Clear();
            txt_datphong.DataBindings.Add("Value", dataGridView1.DataSource, "ID");

            txt_songuoi.DataBindings.Clear();
            txt_songuoi.DataBindings.Add("Value", dataGridView1.DataSource, "SO_NGUOI");

            txt_sophong.DataBindings.Clear();
            txt_sophong.DataBindings.Add("Value", dataGridView1.DataSource, "SO_PHONG");

            txt_ngaydat.DataBindings.Clear();
            txt_ngaydat.DataBindings.Add("Value", dataGridView1.DataSource, "NGAY_DAT");

            txt_ngayden.DataBindings.Clear();
            txt_ngayden.DataBindings.Add("Value", dataGridView1.DataSource, "NGAY_DEN");

            txt_ngaydi.DataBindings.Clear();
            txt_ngaydi.DataBindings.Add("Value", dataGridView1.DataSource, "NGAY_DI");

            txt_nhanvienthuchien.DataBindings.Clear();
            txt_nhanvienthuchien.DataBindings.Add("Text", dataGridView1.DataSource, "ID_NGUOI_THUC_HIEN");

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_QUANLYDATPHONG_Load(object sender, EventArgs e)
        {
            //combobox Nhanvienthuchien
            txt_nhanvienthuchien.DataSource = kn.Lay_DulieuBang("select ID from NHAN_VIEN where CHUC_VU='Tiep tan';");
            txt_nhanvienthuchien.DisplayMember = "ID";
            txt_nhanvienthuchien.ValueMember = "ID";

            BANG_QUANLYDATPHONG();

        }

        private void btn_SUA_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sqlsua = "update DAT_PHONG SET ID_NGUOI_THUC_HIEN = " + txt_nhanvienthuchien.Text + ", SO_NGUOI = " + txt_songuoi.Value + " ,SO_PHONG =" + txt_sophong.Value + ",NGAY_DAT='" + txt_ngaydat.Value + "',NGAY_DEN='" + txt_ngayden.Value + "',NGAY_DI='" + txt_ngaydi.Value + "' where ID=" + txt_datphong.Value + ";";
                kn.ThucThi(sqlsua);
                MessageBox.Show("Bạn đã update thành công!!!");
            }        
        }

        private void btn_XOA_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn Xóa bỏ thông tin đặt phòng này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sqlXOA = "delete DAT_PHONG where ID =" + txt_datphong.Value + " ";
                kn.ThucThi(sqlXOA);
                MessageBox.Show("Bạn đã xóa thành công!!!");
            }        
        }

        private void btn_TimKiemIDkh_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            txt_IDphong.Visible = false;
            // sau khi ấn nút tìm kiếm sẽ hiển thị ra mã id khách hàng ở dòng ID khách hàng
            DataTable dtaID = kn.Lay_DulieuBang("select ID from KHACH_HANG where SDT ='"+txt_SDTtimkiem.Text+"'");

            txt_khachang.DataBindings.Clear();
            txt_khachang.DataBindings.Add("Value", dtaID, "ID");
            // sau đó chuyển datagreatview thành bảng đặt phòng chỉ chứa khách hàng có mã ID tìm kiếm
            dataGridView1.DataSource = kn.Lay_DulieuBang("SELECT dp.ID as ID, dp.ID_KHACH_HANG as ID_KHACH_HANG, dp.ID_NGUOI_THUC_HIEN as ID_NGUOI_THUC_HIEN, dp.SO_NGUOI as SO_NGUOI, dp.SO_PHONG as SO_PHONG, dp.NGAY_DAT as NGAY_DAT, dp.NGAY_DEN as NGAY_DEN, dp.NGAY_DI as NGAY_DI,  dkp.ID_PHONG as ID_Phong FROM DAT_PHONG as dp INNER JOIN DANG_KY_PHONG as dkp ON dp.ID = dkp.ID_DAT_PHONG where DATEDIFF(DAY,GETDATE(),NGAY_DI)<=0 AND ID_Phong NOT IN(SELECT ID_PHONG FROM HOA_DON_PHONG) and dp.id_khach_hang ="+txt_khachang.Value+"");
            //hiện thị dữ liệu lên textbox 
            HIENTHI_DULIEU2();
            btn_SUA.Enabled = false;
            btn_XOA.Enabled = false;
        }

        private void btn_loc_kh_hethan_Click(object sender, EventArgs e)
        {
            txt_songayo.Visible = true;
            label12.Visible = true;
            btn_ThanhToan.Enabled = true;
            label11.Visible = true;
            txt_IDphong.Visible = true;
            
            //lấy dữ liệu từ bảng DAT_PHONG có ngày đi trừ ngày đến <=0
            DataTable dtaID = kn.Lay_DulieuBang("SELECT dp.ID as ID, dp.ID_KHACH_HANG as ID_KHACH_HANG, dp.ID_NGUOI_THUC_HIEN as ID_NGUOI_THUC_HIEN, dp.SO_NGUOI as SO_NGUOI, dp.SO_PHONG as SO_PHONG, dp.NGAY_DAT as NGAY_DAT, dp.NGAY_DEN as NGAY_DEN, dp.NGAY_DI as NGAY_DI,  dkp.ID_PHONG as ID_Phong FROM DAT_PHONG as dp INNER JOIN DANG_KY_PHONG as dkp ON dp.ID = dkp.ID_DAT_PHONG where DATEDIFF(DAY,GETDATE(),NGAY_DI)<=0 AND ID_Phong NOT IN(SELECT ID_PHONG FROM HOA_DON_PHONG)");
            //hiện bảng lên dataGridView1
            dataGridView1.DataSource = dtaID;
            // hiện thị dũ liệu
            HIENTHI_DULIEU();
            //hiển thị dữ liệu riêng cho phần ID phòng
            txt_IDphong.DataBindings.Clear();
            txt_IDphong.DataBindings.Add("Value", dtaID, "ID_Phong");
            btn_SUA.Enabled = false;
            btn_XOA.Enabled = false;
        }

        private void btn_bangdatphong_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            txt_IDphong.Visible = false;
            // hiển thị bảng đặt phòng vì bảng inner join cần có dữ liệu ở bảng đk phòng mới hiển thị lên đc
            dataGridView1.DataSource = kn.Lay_DulieuBang("select * from DAT_PHONG");
            btn_SUA.Enabled = true;
            btn_XOA.Enabled = true;
            btn_ThanhToan.Enabled = false;
            HIENTHI_DULIEU();
        }

        private void btn_timkiemdatphong_Click(object sender, EventArgs e)
        {
            label11.Visible = false;
            txt_IDphong.Visible = false;
            // sau khi ấn nút tìm kiếm sẽ hiển thị ra mã id khách hàng ở dòng ID khách hàng
            DataTable dtaID = kn.Lay_DulieuBang("select ID from KHACH_HANG where SDT ='" + txt_SDTtimkiem.Text + "'");

            txt_khachang.DataBindings.Clear();
            txt_khachang.DataBindings.Add("Value", dtaID, "ID");
            // sau đó chuyển datagreatview thành bảng đặt phòng chỉ chứa khách hàng có mã ID tìm kiếm
            dataGridView1.DataSource = kn.Lay_DulieuBang("SELECT dp.ID as ID, dp.ID_KHACH_HANG as ID_KHACH_HANG, dp.ID_NGUOI_THUC_HIEN as ID_NGUOI_THUC_HIEN, dp.SO_NGUOI as SO_NGUOI, dp.SO_PHONG as SO_PHONG, dp.NGAY_DAT as NGAY_DAT, dp.NGAY_DEN as NGAY_DEN, dp.NGAY_DI as NGAY_DI,  dkp.ID_PHONG as ID_Phong FROM DAT_PHONG as dp INNER JOIN DANG_KY_PHONG as dkp ON dp.ID = dkp.ID_DAT_PHONG where  dp.id_khach_hang =" + txt_khachang.Value + "");
            //hiện thị dữ liệu lên textbox 
            HIENTHI_DULIEU2();
            btn_SUA.Enabled = true;
            btn_XOA.Enabled = true;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            
            DataTable dtaIDq = kn.Lay_DulieuBang("SELECT (DATEDIFF(DAY,NGAY_DEN,NGAY_DI)+1) as SO_NGAY  FROM DAT_PHONG as dp INNER JOIN DANG_KY_PHONG as dkp ON dp.ID = dkp.ID_DAT_PHONG where DATEDIFF(DAY,NGAY_DI,GETDATE())>=0 AND ID_Phong NOT IN(SELECT ID_PHONG FROM HOA_DON_PHONG) and ID_Phong="+txt_IDphong.Value+"");
            txt_songayo.DataBindings.Clear();
            txt_songayo.DataBindings.Add("Value", dtaIDq, "SO_NGAY");
            Console.WriteLine("so ngay o "+txt_songayo.Value);
            Console.WriteLine("so ID phong "+ txt_IDphong.Value);
            Console.WriteLine("so ID dat phong "+ txt_datphong.Value);
            decimal a = txt_datphong.Value;
            decimal c = txt_IDphong.Value;
            decimal p = txt_songayo.Value;
            int b = decimal.ToInt32(a);
            int d = decimal.ToInt32(c);
            int f = decimal.ToInt32(p);
            Frm_THANHTOAN frm = new Frm_THANHTOAN(b, d,f);
            frm.Show();
            this.Hide();
        }
    }
}
