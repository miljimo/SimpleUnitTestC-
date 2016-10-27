using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout
{
    public interface Service
    {
        double purchase(string name, int unit);
        double purchaseRange(Array list);
       
    }
}
