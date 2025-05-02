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
    public partial class FrmChiTietSuDungDV : Form
    {
        KetNoi kn = new KetNoi();
        private void Phong()
        {
            string sql = "select * from phong";
            DataTable dta = kn.Lay_DulieuBang(sql);
            cboTenPhong.DataSource = dta;
            cboTenPhong.DisplayMember = "ten";
            cboIdPhong.DataSource = dta;
            cboIdPhong.DisplayMember = "id";
        }
        private void DichVu()
        {
            string sql = "select * from dich_vu";
            DataTable dta = kn.Lay_DulieuBang(sql);
            cboTenDV.DataSource = dta;
            cboTenDV.DisplayMember = "ten";
        }
        private void HienThiDuLieu()
        {
            txtID_CTSD.DataBindings.Clear();
            cboIdPhong.DataBindings.Clear();
            cboTenPhong.DataBindings.Clear();
            cboTenDV.DataBindings.Clear();
            dateNgayDat.DataBindings.Clear();

            txtID_CTSD.DataBindings.Add("text", dtaGridChiTietSD.DataSource, "ID");
            cboIdPhong.DataBindings.Add("text", dtaGridChiTietSD.DataSource, "ID_PHONG");
            cboTenPhong.DataBindings.Add("text", dtaGridChiTietSD.DataSource, "TEN_PHONG");
            cboTenDV.DataBindings.Add("text", dtaGridChiTietSD.DataSource, "TEN_DV");
            dateNgayDat.DataBindings.Add("value", dtaGridChiTietSD.DataSource, "NGAY_DUNG");

        }
        private void ChiTietSuDungDV()
        {
            string sql = "select ctsd.ID, p.id as ID_PHONG, p.ten as TEN_PHONG, dv.ten as TEN_DV, ctsd.NGAY_DUNG from (phong as p inner join CHI_TIET_SU_DUNG_DV as ctsd on ctsd.ID_PHONG = p.ID) inner join DICH_VU as dv on dv.ID=ctsd.ID_DICH_VU";
            kn.KetNoi_Dulieu();
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang(sql);     
            dtaGridChiTietSD.DataSource = dta;
            HienThiDuLieu();

        }
 
        public FrmChiTietSuDungDV()
        {
            InitializeComponent();
        }

        private void FrmChiTietSuDungDV_Load(object sender, EventArgs e)
        {
            ChiTietSuDungDV();
            Phong();
            DichVu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kn.ThucThi(sql);
            ChiTietSuDungDV();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ngay = dateNgayDat.Value.ToString("yyyy/MM/dd");
            string sql = "";
            if (cbTenDV.Checked)
            {
                sql = "dv.ten = '" + cboTenDV.Text + "' and ";
            }
            if (cbTenPhong.Checked)
            {
                sql += "p.ten = '" + cboTenPhong.Text + "' and ";
            }
            if (cbNgayDung.Checked)
            {
                sql += " ctsd.ngay_dung= '" + ngay + "' and ";
            }
            if (!string.IsNullOrEmpty(sql) && sql.Length >= 4)
            {
                sql = sql.Substring(0, sql.Length - 4);
            }
            else
            {
                MessageBox.Show("Hãy chọn ít nhất một bộ lọc.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string tim = "select ctsd.ID, p.id as ID_PHONG, p.ten as TEN_PHONG, dv.ten as TEN_DV, ctsd.NGAY_DUNG from (phong as p inner join CHI_TIET_SU_DUNG_DV as ctsd on ctsd.ID_PHONG = p.ID) inner join DICH_VU as dv on dv.ID=ctsd.ID_DICH_VU where " + sql + "";
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang(tim);
            dtaGridChiTietSD.DataSource = dta;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            ChiTietSuDungDV();
        }

        private void dateNgayDat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbNgayDung_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
