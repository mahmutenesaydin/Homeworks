using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBusinessLayer.Repository.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> Get();
        void Add(T entity);
        void Edit(T entity);
        void Delete(int id);
        void Delete(T entity);
        T Get(int id);  
    }
}
