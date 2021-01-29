using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DeleteProducts : BusinessClass
    {
        public int ID { get; set; }
        ProductsDataBusiness pdb = new ProductsDataBusiness();

        public override void Ekle()
        {
            
        }

        public override void Guncelle()
        {
            
        }

        public override void Sil()
        {
            pdb.ExecCommand("SP_Delete", new SqlParameter[]
            {
                new SqlParameter("@Id",ID)
            });
        }
    }
}
