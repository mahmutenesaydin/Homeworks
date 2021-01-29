using DataLayer;
using PresentationLayer.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Bridge
{
    public interface IProducts<T>
    {
        List<T> Goster();
        T Onceki { get; }
        T Sonraki { get; }        
    }
    public class ProductsObjects : IProducts<Product>
    {
        private ProductsDBEntities dbp = new ProductsDBEntities();
        private List<Product> prodc;
        private int _mevcut;
        public ProductsObjects()
        {
            prodc = dbp.Products.ToList();
        }
        public Product Onceki
        {
            get
            {
                if (_mevcut > 0)
                    _mevcut--;
                return prodc[_mevcut];

            }
        }
        public Product Sonraki
        {
            get
            {
                if (_mevcut < prodc.Count - 1)
                    _mevcut++;
                return prodc[_mevcut];
            }
        } 

        public List<Product> Goster()
        {
            return prodc;
        }
    }


    public class Productss
    {
        public IProducts<Product> ProductObject { get; set; }
        public Product Onceki
        {
            get
            {
                return ProductObject.Onceki;
            }
        }
        public Product Sonraki
        {
            get
            {
                return ProductObject.Sonraki;
            }
        }       
        public List<Product> Show()
        {
            return ProductObject.Goster();
        }
    }
}
