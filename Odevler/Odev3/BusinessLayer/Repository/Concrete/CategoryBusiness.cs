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
    public class CategoryBusiness : IDatabaseBusiness<Category>
    {
        //Odev3Entities db = new Odev3Entities();,
        Odev3Entities1 db = new Odev3Entities1();

        public void Add(Category t)
        {
            db.Categories.Add(t);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryId = db.Categories.Find(id);
            db.Categories.Remove(categoryId);
            db.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> predicate)
        {
            return db.Categories.Where(predicate).FirstOrDefault();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Update(Category t)
        {
            db.Categories.Attach(t);
            db.Entry<Category>(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
