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
    public partial class Frm_Phong : Form
    {
        public Frm_Phong()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        private void BangPhong()
        {
            string sql = "select * from phong";
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang(sql);
            dataGridPhong.DataSource = dta;
            btnluu.Enabled = false;
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            nmrId.DataBindings.Clear();
            nmrId.DataBindings.Add("value", dataGridPhong.DataSource, "id");
            nmrIdLoaiPhong.DataBindings.Clear();
            nmrIdLoaiPhong.DataBindings.Add("value", dataGridPhong.DataSource, "id_loai_phong");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dataGridPhong.DataSource, "ten");
            cboTrangthai.DataBindings.Clear();
            cboTrangthai.DataBindings.Add("text", dataGridPhong.DataSource, "trang_thai");

        }
        private void TrangThai()
        {
            cboTrangthai.Items.Add("Trong");
            cboTrangthai.Items.Add("Ban");
        }
        private void Frm_Phong_Load(object sender, EventArgs e)
        {
            BangPhong();
            TrangThai();
            nmrId.Enabled = false;
            
        }

        private void btntao_moi_Click(object sender, EventArgs e)
        {
            nmrId.DataBindings.Clear();
            DataTable dta = kn.Lay_DulieuBang("select (Max(id)+1) as id from phong");
            nmrId.DataBindings.Add("value", dta, "id");
            txtTen.Text = "";
            btnluu.Enabled = true;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn lưu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "insert into phong values(" + nmrId.Value + "," + nmrIdLoaiPhong.Value + ",'" + txtTen.Text + "','" + cboTrangthai.Text + "')";
                kn.ThucThi(sql);
            }            
            BangPhong();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn sửa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "update phong set id_loai_phong = " + nmrIdLoaiPhong.Value + ", ten = '" + txtTen.Text + "', trang_thai='" + cboTrangthai.Text + "' where id= " + nmrId.Value + "";
                kn.ThucThi(sql);
            }
                
            BangPhong();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn xác định muốn xoá!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string sql = "delete from phong where id = " + nmrId.Value + "";
                kn.ThucThi(sql);
            }
            BangPhong();
        }
    }
}
