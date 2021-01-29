using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UpdateProducts : BusinessClass
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string stock { get; set; }
        ProductsDataBusiness pdb = new ProductsDataBusiness();
        public override void Ekle()
        {

        }

        public override void Guncelle()
        {
            pdb.ExecCommand("SP_Update", new SqlParameter[] {
                new SqlParameter("@Id",ID),
                new SqlParameter("@Name",name),
                new SqlParameter("@Price",price),
                new SqlParameter("@Stock",stock)
            });
        }

        public override void Sil()
        {
        }
    }
}
