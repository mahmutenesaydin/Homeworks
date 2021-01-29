using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using CRMDbDataService.Models;

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
        public class AutoHeader : SoapHeader
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        const string _userName = "mahmut";
        const string _password = "123";
        public AutoHeader Kimlik;

        [WebMethod(EnableSession = true)]
        public string Login(string username, string password)
        {
            string key = string.Empty;
            if (username == _userName && password == _password)
            {
                key = Guid.NewGuid().ToString();
                Session["LGN"] = key;
            }
            return key;
        }


        [WebMethod(EnableSession = true)]
        public List<Product>

    }
}
