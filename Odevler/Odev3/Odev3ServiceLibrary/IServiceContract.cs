using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Odev3ServiceLibrary
{
    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        void AddCategory(Category cat);
        [OperationContract]
        void UpdateCategory(Category cat);
        [OperationContract]
        void DeleteCategory(int cat);
        [OperationContract]
        List<Category> ListCategory();
        [OperationContract]
        void AddProduct(Product prod);
        [OperationContract]
        void UpdateProduct(Product prod);
        [OperationContract]
        void DeleteProduct(int prod);
        [OperationContract]
        List<Product> ListProduct();
        [OperationContract]
        void AddSupplier(Supplier sup);
        [OperationContract]
        void UpateSupplier(Supplier sup);
        [OperationContract]
        void DeleteSupplier(int sup);
        [OperationContract]
        List<Supplier> ListSupplier();

        [OperationContract]
        bool Login(string UserName, string Password);
    }
}
