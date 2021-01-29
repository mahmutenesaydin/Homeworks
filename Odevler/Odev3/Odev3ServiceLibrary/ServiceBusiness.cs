using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.Repository.Concrete;

namespace Odev3ServiceLibrary
{ 
    public class ServiceBusiness : IServiceContract

    {
        // Odev3Entities db = new Odev3Entities();
        Odev3Entities1 db = new Odev3Entities1();
        CategoryBusiness catBus = new CategoryBusiness();
        ProductBusiness prodBus = new ProductBusiness();
        SupplierBusiness supBus = new SupplierBusiness();
        EmployeeBusiness empBus = new EmployeeBusiness();

        public void AddCategory(Category cat)
        {
            catBus.Add(cat);
        }

        public void AddProduct(Product prod)
        {
            prodBus.Add(prod);
        }

        public void AddSupplier(Supplier sup)
        {
            supBus.Add(sup);
        }

        public void DeleteCategory(int cat)
        {
            catBus.Delete(cat);
        }

        public void DeleteProduct(int prod)
        {
            prodBus.Delete(prod);
        }

        public void DeleteSupplier(int sup)
        {
            supBus.Delete(sup);
        }

        public List<Category> ListCategory()
        {
            return catBus.GetAll();
        }

        public List<Product> ListProduct()
        {
            return prodBus.GetAll();
        }

        public List<Supplier> ListSupplier()
        {
            return supBus.GetAll();
        }

        public void UpateSupplier(Supplier sup)
        {
            supBus.Update(sup);
        }

        public void UpdateCategory(Category cat)
        {
            catBus.Update(cat);
        }

        public void UpdateProduct(Product prod)
        {
            prodBus.Update(prod);
        }

        public bool Login(string UserName, string Password)
        {
            var user = db.Employees.FirstOrDefault(e => e.LastName == UserName);
            if (user != null)
            {
                if (user.City==Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
