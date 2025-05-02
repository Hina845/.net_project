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
        private int idHoaDon;
        public FrmBaoCao(int a)
        {
            InitializeComponent();
            this.idHoaDon = a;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        KetNoi kn = new KetNoi();

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            Console.WriteLine(idHoaDon);
            dta = kn.Lay_DulieuBang("select * from hoa_don_phong where id = " + idHoaDon.ToString());
            HOADON bc = new HOADON();
            bc.SetDataSource(dta);
            crvTest.ReportSource=bc;
        }
    }
}
