using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Repository.Abstract
{
    public interface IDatabaseBusiness<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(int id);
        List<T> GetAll();
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);
    }
}
