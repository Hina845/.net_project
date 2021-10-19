using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class FrmLogin : Form
    {
        KetNoi kn = new KetNoi();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string DN = txtDangNhap.Text;
            string MK = txtMatKhau.Text;

            string sql_login="select TK,MK from TAI_KHOAN WHERE TK= '" + DN + "' AND MK='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!!");
                //Form frmmain = new FrmMain();
                //frmmain.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (thongbao == DialogResult.OK) this.Close();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
