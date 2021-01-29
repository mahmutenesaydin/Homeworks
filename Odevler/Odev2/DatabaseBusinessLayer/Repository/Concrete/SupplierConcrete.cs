using DatabaseBusinessLayer.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind_Entities;

namespace DatabaseBusinessLayer.Repository.Concrete
{
    public class SupplierConcrete : ISupplierRepository
    {
        public void Add(Supplier entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Suppliers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Supplier entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Suppliers.Attach(entity);
                db.Entry<Supplier>(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                var s = db.Suppliers.Find(id);
                db.Suppliers.Remove(s);
                db.SaveChanges();
            }
        }

        public void Edit(Supplier entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Suppliers.Attach(entity);
                db.Entry<Supplier>(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Supplier> Get()
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Suppliers.ToList();
            }
        }

        public Supplier Get(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Suppliers.Find(id);
            }
        }
    }
}
