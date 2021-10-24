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
    public partial class Frm_DATPHONG : Form
    {
        private int ID;
        public Frm_DATPHONG()
        {
            InitializeComponent();
        }

        KetNoi kn = new KetNoi();
        public Frm_DATPHONG(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void Frm_DATPHONG_Load(object sender, EventArgs e)
        {
            txt_khachang.DataBindings.Clear();
            txt_khachang.Value = ID;
        }

        private void btn_chitietdatphong_Click(object sender, EventArgs e)
        {
            String sql_insert = "insert into DAT_PHONG values("+txt_datphong.Value+","+txt_khachang.Value+","+txt_nhanvienthuchien.Value+","+txt_songuoi.Value+","+txt_sophong.Value+",'"+txt_ngaydat.Value+"','"+txt_ngayden.Value+"','"+txt_ngaydi.Value+"')";
            kn.ThucThi(sql_insert);
            // thêm đường dẫn để đến form chi tiết đặt phòng
        }
    }
}
