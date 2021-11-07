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
    public partial class FrmThietBi : Form
    {
        KetNoi kn = new KetNoi();
        public FrmThietBi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HienThiDuLieu()
        {
            nmrID.DataBindings.Clear();
            nmrID.DataBindings.Add("value", dtaGridThietBi.DataSource, "id");
            nmrGia.DataBindings.Clear();
            nmrGia.DataBindings.Add("value", dtaGridThietBi.DataSource, "gia");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dtaGridThietBi.DataSource, "ten");
        }
        private void BANG_THIET_BI()
        {
            DataTable dta = new DataTable();
            String sql = @"select * from thiet_bi";
            dta = kn.Lay_DulieuBang(sql);
            dtaGridThietBi.DataSource = dta;
            HienThiDuLieu();
        }
        private void FrmThietBi_Load(object sender, EventArgs e)
        {
            
            kn.KetNoi_Dulieu();
            BANG_THIET_BI();
            btnLuu.Enabled = false;
        }

        private void dtaGridThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled=true;
            txtTen.Text = "";
            nmrGia.Value = 0;
            nmrID.Value = 0;
            
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn lưu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sql = @"insert into thiet_bi values(" + nmrID.Value + ",'" + txtTen.Text + "'," + nmrGia.Value + ")";
                kn.ThucThi(sql);
                BANG_THIET_BI();
                btnLuu.Enabled = false;
            }
                
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn sửa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sql = @"update Thiet_Bi set ten='" + txtTen.Text + "',gia=" + nmrGia.Value + " where id=" + nmrID.Value + "";
                kn.ThucThi(sql);
                BANG_THIET_BI();
            }
                
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn xoá!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String sql = @"Delete from Thiet_Bi where id='" + nmrID.Value + "'";
                kn.ThucThi(sql);
                BANG_THIET_BI();
            }
                
        }
    }
}
