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
    public partial class Frm_DangKySuDungDv : Form
    {
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            nmrIDdichvu.DataBindings.Clear();
            nmrIDdichvu.DataBindings.Add("value", dtaGridDichVu.DataSource, "id");
            txtDichVU.DataBindings.Clear();
            txtDichVU.DataBindings.Add("text", dtaGridDichVu.DataSource, "ten");
        }
        private void BANG_DICHVU()
        {
            String sql = "select * from dich_vu";
            DataTable dta = new DataTable();
            kn.KetNoi_Dulieu();
            dta = kn.Lay_DulieuBang(sql);
            dtaGridDichVu.DataSource = dta;
            HienThiDuLieu();
            btnLuu.Enabled = false;
        }

        public Frm_DangKySuDungDv()
        {
            InitializeComponent();
        }

        private void Frm_DangKySuDungDv_Load(object sender, EventArgs e)
        {
            BANG_DICHVU();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn đăng ký sử dụng dịch vụ này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string ngay = dateNgayDat.Value.ToString("yyyy/MM/dd");
                string sql = "insert into chi_tiet_su_dung_dv values(" + nmrID.Value + "," + nmrIDphong.Value + "," + nmrIDdichvu.Value + ",'" + ngay + "')";
                kn.ThucThi(sql);
                btnLuu.Enabled = false;
            }            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            nmrID.Value = 0;
            nmrID.Focus();
            btnLuu.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
