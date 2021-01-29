using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductsDataBusiness
    {
        private string conStr = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        public void ExecCommand(string cmd, SqlParameter[] sqlPara)
        {
            SqlConnection conn = new SqlConnection(conStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cm = new SqlCommand(cmd, conn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddRange(sqlPara);
            cm.ExecuteNonQuery();
            cm.Dispose();
            conn.Close();
        }
        public DataTable execadapter(string cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd, conStr);
            DataTable datat = new DataTable();
            da.Fill(datat);
            return datat;

        }
    }
}
