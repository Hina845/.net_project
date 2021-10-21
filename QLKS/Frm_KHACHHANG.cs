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
    public partial class Frm_KHACHHANG : Form
    {
        public Frm_KHACHHANG()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void Bang_KhachHang()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from KHACH_HANG");
            dataGridKhachHang.DataSource = dta;
            HienThi_DuLieu();
        }
        private void Frm_KHACHHANG_Load(object sender, EventArgs e)
        {
            Bang_KhachHang();
            
        }
        public void HienThi_DuLieu()
        {
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Value", dataGridKhachHang.DataSource, "ID");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dataGridKhachHang.DataSource, "TEN");

            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add("Text", dataGridKhachHang.DataSource, "SDT");

            txtGmail.DataBindings.Clear();
            txtGmail.DataBindings.Add("Text", dataGridKhachHang.DataSource, "GMAIL");

            txtCMT.DataBindings.Clear();
            txtCMT.DataBindings.Add("Text", dataGridKhachHang.DataSource, "CMND");

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add("Text", dataGridKhachHang.DataSource, "DIA_CHI");

            txtNation.DataBindings.Clear();
            txtNation.DataBindings.Add("Text", dataGridKhachHang.DataSource, "QUOC_GIA");
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtID.Value = 0;
            txtName.Text = "";
            txtPhone.Text = "";
            txtCMT.Text = "";
            txtGmail.Text = "";
            txtAddress.Text = "";
            txtNation.Text = "";
            txtID.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql_luu;
            sql_luu = "INSERT INTO KHACH_HANG VALUES (" + txtID.Value + " , '" + txtName.Text + "' , '" + txtPhone.Text + "' , '" + txtGmail.Text + "' , '" + txtCMT.Text + "' , '" + txtAddress.Text + "' , '" + txtNation.Text + "')";
            kn.ThucThi(sql_luu);
            Bang_KhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql_sua;
            sql_sua = "UPDATE KHACH_HANG SET TEN = '" + txtName.Text + "' , SDT = '" + txtPhone.Text + "' , GMAIL = '" + txtGmail.Text + "' , CMND = '" + txtCMT.Text + "' , DIA_CHI = '" + txtAddress.Text + "' ,QUOC_GIA = '" + txtNation.Text + "' WHERE ID = " + txtID.Value +" ";
            kn.ThucThi(sql_sua);
            Bang_KhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql_xoa;
            sql_xoa = "DELETE KHACH_HANG WHERE ID = " + txtID.Value + " ";
            kn.ThucThi(sql_xoa);
            Bang_KhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThi_DuLieu();
        }
    }
}
