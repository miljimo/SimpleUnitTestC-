using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout
{
    interface TryAdd<T>
    {
        bool add(T item, double name);
    }
}
