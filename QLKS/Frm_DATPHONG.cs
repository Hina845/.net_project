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
    }
}
