using Northwind_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProductService : INorthwindService<Product>
    {
        public void Add(Product entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Products.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Products.Attach(entity);
                db.Entry<Product>(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                var p = db.Products.Find(id);
                db.Products.Remove(p);
                db.SaveChanges();
            }
        }

        public void Edit(Product entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Products.Attach(entity);
                db.Entry<Product>(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Product> Get()
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Products.Find(id);
            }
        }
    }
}
