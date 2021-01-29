using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1___Odev
{
    public class DatabaseBusiness
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Data Source=ABC-BILGISAYAR\\MHMTENES13;Initial Catalog=CRMDB;Integrated Security=True"].ConnectionString;

        public void ExecuteCommand(string cmdText, SqlParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand(cmdText, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
        }

            public DataTable ExecuteAdapter(string cmdText)
        {
            SqlDataAdapter ad = new SqlDataAdapter(cmdText,connectionString);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        
        public DataTable ExecuteAdapter(string cmdText, SqlParameter[] parameters)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmdText, connectionString);
            da.SelectCommand.Parameters.AddRange(parameters);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
                
    }
}
