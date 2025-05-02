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
    public partial class FormChiTietThietBi : Form
    {
        KetNoi kn = new KetNoi();
        private void HienThiDuLieu()
        {
            txtID_CTTB.DataBindings.Clear();
            cboIdPhong.DataBindings.Clear();
            cboTenPhong.DataBindings.Clear();
            cboTenTb.DataBindings.Clear();
            cboTrangThai.DataBindings.Clear();
            
            txtID_CTTB.DataBindings.Add("value", dtaGridChiTietTB.DataSource, "ID_CTTB");
            cboIdPhong.DataBindings.Add("text", dtaGridChiTietTB.DataSource, "ID_PHONG");
            cboTenPhong.DataBindings.Add("text", dtaGridChiTietTB.DataSource, "TEN_PHONG");
            cboTenTb.DataBindings.Add("text", dtaGridChiTietTB.DataSource, "TEN_TB");
            cboTrangThai.DataBindings.Add("text", dtaGridChiTietTB.DataSource, "TRANG_THAI");

            
        }
        private void BANG_CHITIETTHIETBI()
        {
            string sql = "select p.id as ID_PHONG, p.ten as TEN_PHONG, cttb.id as ID_CTTB, tb.ten as TEN_TB, cttb.TRANG_THAI  from phong as p inner join CHI_TIET_THIET_BI as cttb on p.id = cttb.ID_PHONG inner join THIET_BI as tb on cttb.ID_THIET_BI= tb.ID";
            kn.KetNoi_Dulieu();
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang(sql);
            dtaGridChiTietTB.DataSource = dta;
            HienThiDuLieu();
            btnChen.Enabled = false;
            cboIdPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            txtID_CTTB.Enabled = false;

        }
        private void TRANGTHAI()
        {
            cboTrangThai.Items.Add("Tot");
            cboTrangThai.Items.Add("Hong");
        }
        private void TenThietBi()
        {
            string sql = "select * from thiet_bi";
            DataTable dta = kn.Lay_DulieuBang(sql);
            cboTenTb.DataSource = dta;
            cboTenTb.DisplayMember = "ten";
        }
        private void Phong()
        {
            string sql = "select * from phong";
            DataTable dta = kn.Lay_DulieuBang(sql);
            cboTenPhong.DataSource = dta;
            cboTenPhong.DisplayMember = "ten";
            cboIdPhong.DataSource = dta;
            cboIdPhong.DisplayMember = "id";
        }
        
        public FormChiTietThietBi()
        {
            InitializeComponent();
        }

        private void FormChiTietThietBi_Load(object sender, EventArgs e)
        {
            BANG_CHITIETTHIETBI();
            TRANGTHAI();
            TenThietBi();
            Phong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtaId = kn.Lay_DulieuBang("select (MAX(id)+1) as id from chi_tiet_thiet_bi");
            txtID_CTTB.DataBindings.Clear();
            txtID_CTTB.DataBindings.Add("value", dtaId, "id");
            btnChen.Enabled = true;
            cboIdPhong.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn sửa!", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "update CHI_TIET_THIET_BI set id_thiet_bi=" + (cboTenTb.SelectedIndex + 1) + ",id_phong='" + cboIdPhong.Text + "',trang_thai='" + cboTrangThai.Text + "' where id='" + txtID_CTTB.Text + "'";
                kn.ThucThi(sql);
            }
            BANG_CHITIETTHIETBI();
        }

        private void btnChen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn lưu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "insert into CHI_TIET_THIET_BI values('" + txtID_CTTB.Value + "'," + (cboTenTb.SelectedIndex + 1) + ",'" + (cboIdPhong.Text) + "','" + cboTrangThai.Text + "')";
                kn.ThucThi(sql);
                
            }
            BANG_CHITIETTHIETBI();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn xoá!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "delete from CHI_TIET_THIET_BI where id='" + txtID_CTTB.Value + "'";
                kn.ThucThi(sql);
            }
            BANG_CHITIETTHIETBI();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            
                string sql = "";
                if (cbTrangThai.Checked)
                {
                    sql = "cttb.trang_thai = '" + cboTrangThai.Text + "' and ";
                }
                if (cbTenPhong.Checked)
                {
                    sql += "p.ten = '" + cboTenPhong.Text + "' and ";
                }
                if (cbTenTb.Checked)
                {
                    sql += "tb.ten = '" + cboTenTb.Text + "' and ";
                }
                sql = sql.Substring(0, sql.Length - 4);
                string tim = "select p.id as ID_PHONG, p.ten as TEN_PHONG, cttb.id as ID_CTTB, tb.ten as TEN_TB, cttb.TRANG_THAI  from phong as p inner join CHI_TIET_THIET_BI as cttb on p.id = cttb.ID_PHONG inner join THIET_BI as tb on cttb.ID_THIET_BI= tb.ID where " + sql + "";
                DataTable dta = new DataTable();
                dta = kn.Lay_DulieuBang(tim);
                dtaGridChiTietTB.DataSource = dta;
                        
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            BANG_CHITIETTHIETBI();
            txtID_CTTB.Enabled = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
