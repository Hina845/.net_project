using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;              
using System.Data.SqlClient; // Khai báo thư viện
namespace QLKS
{
    class KetNoi
    {
        public SqlConnection cnn;
        public SqlCommand cmd;
        public DataTable dta;
        public SqlDataAdapter ada;
       
        public void KetNoi_Dulieu()
        {



            string strKetNoi = @"Data Source=LAPTOP-OGIL9U3L\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";



            
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }
     
        public void HuyKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public DataTable Lay_DulieuBang(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string sql)
        {
            KetNoi_Dulieu();
            cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            HuyKetNoi();
        }
    }
}
