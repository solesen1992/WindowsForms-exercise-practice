using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_NotSoCoolShop.DataAccessLayer.Interfaces
{
    internal interface ICRUD<T>
    {
        void Create(T entity); // Should give a product. We just call it entity.
        T Get(int id); // Read functionality. Should be able to get it through an id.
        IEnumerable<T> GetAll(); // Gets an collection back of the type T
        void Update(T entity);
        void Delete(int id);
    }
}
