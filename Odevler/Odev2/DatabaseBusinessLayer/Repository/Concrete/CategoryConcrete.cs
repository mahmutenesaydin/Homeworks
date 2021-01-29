using DatabaseBusinessLayer.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind_Entities;

namespace DatabaseBusinessLayer.Repository.Concrete
{
    public class CategoryConcrete : ICategoryRepository
    {
        public void Add(Category entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Categories.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Categories.Attach(entity);
                db.Entry<Category>(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                var c = db.Categories.Find(id);
                db.Categories.Remove(c);
                db.SaveChanges();
            }
        }

        public void Edit(Category entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Categories.Attach(entity);
                db.Entry<Category>(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Category> Get()
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Categories.ToList();
            }
        }

        public Category Get(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Categories.Find(id);
            }
        }
    }
}
