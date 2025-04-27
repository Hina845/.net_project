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
    public partial class FrmLoaiPhong : Form
    {
        public FrmLoaiPhong()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();

        private void Bang_LoaiPhong()
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("Select * from LOAI_PHONG");
            dataGridLoaiPhong.DataSource = dta;
            HienThi_DuLieu();
        }

        private void FrmLoaiPhong_Load(object sender, EventArgs e)
        {
            Bang_LoaiPhong();
        }

        public void HienThi_DuLieu()
        {
            txtma_loai.DataBindings.Clear();
            txtma_loai.DataBindings.Add("Value", dataGridLoaiPhong.DataSource, "ID");

            txtten_loai.DataBindings.Clear();
            txtten_loai.DataBindings.Add("Text", dataGridLoaiPhong.DataSource, "TEN");

            txtso_nguoi.DataBindings.Clear();
            txtso_nguoi.DataBindings.Add("Value", dataGridLoaiPhong.DataSource, "SO_NGUOI");

            txtgia.DataBindings.Clear();
            txtgia.DataBindings.Add("Value", dataGridLoaiPhong.DataSource, "GIA");

            txtmo_ta.DataBindings.Clear();
            txtmo_ta.DataBindings.Add("Text", dataGridLoaiPhong.DataSource, "MO_TA");
        }

        private void btntao_moi_Click(object sender, EventArgs e)
        {
            txtma_loai.Value = 0;
            txtten_loai.Text = "";
            txtso_nguoi.Value = 0;
            txtgia.Value = 0;
            txtmo_ta.Text = "";
            txtma_loai.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked");
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn lưu không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
            {
                string sql_luu;
                sql_luu = "INSERT INTO LOAI_PHONG VALUES (" + txtma_loai.Value + " , '" + txtten_loai.Text + "' , " + txtso_nguoi.Value + " , " + txtgia.Value + " , '" + txtmo_ta.Text + "')";
                kn.ThucThi(sql_luu);
               
                MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            Bang_LoaiPhong();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
            {
                string sql_sua;
                sql_sua = "UPDATE LOAI_PHONG SET TEN = '" + txtten_loai.Text + "' , SO_NGUOI = " + txtso_nguoi.Value + " , GIA = " + txtgia.Value + " , MO_TA = '" + txtmo_ta.Text + "' WHERE ID = " + txtma_loai.Value + " ";
                kn.ThucThi(sql_sua);
                
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            Bang_LoaiPhong();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK)
            {
                string sql_xoa;
                sql_xoa = "DELETE LOAI_PHONG WHERE ID = " + txtma_loai.Value + " ";
                kn.ThucThi(sql_xoa);
                
                MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            Bang_LoaiPhong();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridLoaiPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HienThi_DuLieu();
        }
    }
}
