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
    public class EmployeeBusiness : IDatabaseBusiness<Employee>
    {
       // Odev3Entities db = new Odev3Entities();
        Odev3Entities1 db = new Odev3Entities1();

        public void Add(Employee t)
        {
            db.Employees.Add(t);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeeId = db.Employees.Find(id);
            db.Employees.Remove(employeeId);
            db.SaveChanges();
        }

        public Employee Get(Expression<Func<Employee, bool>> predicate)
        {
            return db.Employees.Where(predicate).FirstOrDefault();
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public void Update(Employee t)
        {
            db.Employees.Attach(t);
            db.Entry<Employee>(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
