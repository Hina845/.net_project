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
            decimal a = txt_datphong.Value;
            decimal c = txt_sophong.Value;
            int b = decimal.ToInt32(a);
            int d = decimal.ToInt32(c);
                
            Frm_DANGKIPHONG frm = new Frm_DANGKIPHONG(b, d);
            frm.Show();
            this.Hide();
        }

 

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
