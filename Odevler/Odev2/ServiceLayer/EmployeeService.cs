using Northwind_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class EmployeeService : INorthwindService<Employee>
    {
        public void Add(Employee entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Employees.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Employees.Attach(entity);
                db.Entry<Employee>(entity).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                var e = db.Employees.Find(id);
                db.Employees.Remove(e);
                db.SaveChanges();
            }
        }

        public void Edit(Employee entity)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                db.Employees.Attach(entity);
                db.Entry<Employee>(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Employee> Get()
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Employees.ToList(); 
            }
        }

        public Employee Get(int id)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                return db.Employees.Find(id);
            }
        }
    }
}
