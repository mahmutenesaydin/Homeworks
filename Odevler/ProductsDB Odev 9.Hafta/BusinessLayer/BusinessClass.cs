using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class BusinessClass
    {

        public abstract void Ekle();
        public abstract void Guncelle();
        public abstract void Sil();

        public void CRUD()
        {
            Ekle();
            Guncelle();
            Sil();
        }
    }

}
