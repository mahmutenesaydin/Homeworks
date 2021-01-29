using BusinessLayer.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using DataLayer;

namespace BusinessLayer.Repository.Concrete
{
    public class ProductBusiness : IDatabaseBusiness<Product>
    {

        //    Odev3Entities db = new Odev3Entities();
        Odev3Entities1 db = new Odev3Entities1();

        public void Add(Product t)
        {
            db.Products.Add(t);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var productId = db.Products.Find(id);
            db.Products.Remove(productId);
            db.SaveChanges();
        }

        public Product Get(Expression<Func<Product, bool>> predicate)
        {
            return db.Products.Where(predicate).FirstOrDefault();
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public void Update(Product t)
        {
            db.Products.Attach(t);
            db.Entry<Product>(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

    }
}
