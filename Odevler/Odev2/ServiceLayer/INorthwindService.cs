using Northwind_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayer
{
    [ServiceContract]
    public interface INorthwindService<T> where T:class
    {
        [OperationContract]
        List<T> Get();
        [OperationContract]
        void Add(T entity);
        [OperationContract]
        void Edit(T entity);
        [OperationContract]
        void Delete(int id);
        [OperationContract]
        void Delete(T entity);
        [OperationContract]
        T Get(int id);
    }
}
