using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace CRMDbDataService
{
    /// <summary>
    /// Summary description for ProductDataService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductDataService : System.Web.Services.WebService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        Models.DataBusiness dataBus = new Models.DataBusiness();

        public class AutoHeader : SoapHeader
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        const string _userName = "mhmtens";
        const string _password = "13";
        public AutoHeader Kimlik;

        [WebMethod(EnableSession = true)]
        public string Login(string userName, string password)
        {
            string key = string.Empty;
            if (userName == _userName && password == _password)
            {
                key = Guid.NewGuid().ToString();
                Session["LGN"] = key;
            }
            return key;
        }

        [WebMethod(EnableSession = true)]
        public DataTable List(string key)
        {
            string cmdText = "exec SP_Select";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdText, connectionString);
            DataTable dt = new DataTable();
            dt.TableName = "Products";
            adapter.Fill(dt);
            return dt;
        }

        [WebMethod]
        [SoapHeader("Kimlik")]
        public string Insert(string name, double price, int stock)
        {
            if (Kimlik.UserName == "admin" && Kimlik.Password == "1")
            {
                try
                {
                    dataBus.ExecuteCommand("SP_Insert", new SqlParameter[]
                    {
                        new SqlParameter("@Name",name),
                        new SqlParameter("@Price",price),
                        new SqlParameter("@Stock",stock)
                    });
                    return "Success";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Yetkisiz";
            }
        }

        [WebMethod]
        [SoapHeader("Kimlik")]
        public string Update(int id, string name, double price, int stock)
        {
            if (Kimlik.UserName == "admin" && Kimlik.Password == "1")
            {
                try
                {
                    dataBus.ExecuteCommand("SP_Update", new SqlParameter[]
                    {
                        new SqlParameter("@Id",id.ToString()),
                        new SqlParameter("@Name",name),
                        new SqlParameter("@Price",price),
                        new SqlParameter("@Stock",stock)
                    });
                    return "Success";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Yetkisiz";
            }
        }

        [WebMethod]
        [SoapHeader("Kimlik")]
        public string Delete(int id)
        {
            if (Kimlik.UserName == "admin" && Kimlik.Password == "1")
            {
                try
                {
                    dataBus.ExecuteCommand("SP_Delete", new SqlParameter[]
                    {
                        new SqlParameter("@Id",id.ToString())
                    });
                    return "Success";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
            {
                return "Yetkisiz";
            }
        }
    }
}
