using BusinessLayer.Repository.Abstract;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BusinessLayer.Repository.Concrete
{
    public class SupplierBusiness : IDatabaseBusiness<Supplier>
    {
        //  Odev3Entities db = new Odev3Entities();
        Odev3Entities1 db = new Odev3Entities1();

        public void Add(Supplier t)
        {
            db.Suppliers.Add(t);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplierId = db.Suppliers.Find(id);
            db.Suppliers.Remove(supplierId);
            db.SaveChanges();
        }

        public Supplier Get(Expression<Func<Supplier, bool>> predicate)
        {
            return db.Suppliers.Where(predicate).FirstOrDefault();
        }

        public Supplier Get(int id)
        {
            return db.Suppliers.Find(id);
        }

        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }

        public void Update(Supplier t)
        {
            db.Suppliers.Attach(t);
            db.Entry<Supplier>(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
