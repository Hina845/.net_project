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
    public partial class FrmBaoCao : Form
    {
        private int idPhong;
        public FrmBaoCao(int a)
        {
            InitializeComponent();
            this.idPhong = a;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        KetNoi kn = new KetNoi();

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            dta = kn.Lay_DulieuBang("select * from phong where id = "+idPhong+"");
            HOADON bc = new HOADON();
            bc.SetDataSource(dta);
            crvTest.ReportSource=bc;
        }
    }
}
