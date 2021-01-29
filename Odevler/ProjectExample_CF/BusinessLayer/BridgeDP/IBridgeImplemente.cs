using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.BridgeDP
{
    public interface IBridgeImplemente<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(int id);
        List<T> List();
    }
}
