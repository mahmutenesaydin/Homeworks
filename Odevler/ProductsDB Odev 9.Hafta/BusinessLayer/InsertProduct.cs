using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class InsertProducts : BusinessClass
    {
        public string name { get; set; }
        public string price { get; set; }
        public string stock { get; set; }
        ProductsDataBusiness pdb = new ProductsDataBusiness();
        public override void Ekle()
        {
            pdb.ExecCommand("SP_Insert", new SqlParameter[] 
            {
                new SqlParameter("@Name",name),
                new SqlParameter("@Price",price),
                new SqlParameter("@Stock",stock)
            });

        }
        public override void Guncelle()
        {
        }

        public override void Sil()
        {            
        }
    }

}
