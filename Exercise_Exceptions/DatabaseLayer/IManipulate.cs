using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Exceptions.DatabaseLayer
{
    public interface IManipulate<T>
    {
        int Save(T someData);
    }
}
