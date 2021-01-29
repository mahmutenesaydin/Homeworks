using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    //public abstract class DatabaseBussines<T> where T : class
    //{
    //    public abstract List<T> List();
    //    public abstract void Create(T t);
    //    public abstract T Read(int ID);
    //    public abstract void Update(T t);
    //    public abstract void Delete(T t);
    //    public abstract void Delete(int ID);
    //}

    public interface IDatabaseBusiness<T>
    {
        //void Create(T t);
        //void Read(T t);
        //void Update(T t);
        //void Delete(T t);

        List<T> List();
        void Create(T t);
        T Read(int ID);
        void Update(T t);
        void Delete(T t);
        void Delete(int ID);
    }

    public class CustomerDatabaseBusiness : IDatabaseBusiness<Customer>
    {
        BankaDBEntities db = new BankaDBEntities();

        public void Create(Customer t)
        {
            db.Customers.Add(t);
            db.SaveChanges();
        }

        public void Delete(int ID)
        {
            Customer cus = db.Customers.Find(ID);
            db.Customers.Remove(cus);
            db.SaveChanges();
        }

        public void Delete(Customer t)
        {
            db.Customers.Remove(t);
            db.SaveChanges();
        }

        public List<Customer> List()
        {
            return db.Customers.ToList();
        }

        public Customer Read(int ID)
        {
            return db.Customers.SingleOrDefault(c => c.CustomerID == ID);
        }

        public void Update(Customer t)
        {
            db.Customers.Attach(t);
            db.Entry(t).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }

    public class CustomerBase
    {
        public IDatabaseBusiness<Customer> DataObject { get; set; }
        public void Create(Customer cust) { DataObject.Create(cust); }
       //public void Read(Customer cust) { DataObject.Read(ID); }
        public void Update(Customer cust) { DataObject.Update(cust); }
        public void Delete(Customer cust) { DataObject.Delete(cust); }
    }
}
