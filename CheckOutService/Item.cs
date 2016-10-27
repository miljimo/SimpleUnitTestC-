using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout
{
  public  struct Item
    {
       public int  units { get; }
       public string name { get; }

       public Item(string name, int nUnits)
        {
            this.units = nUnits;
            this.name = name;
        }    
            
    }

  public struct StockItem
    {
        public string name  { get; }
        public double price { get; }
        public StockItem(string name, double price)
        {
            this.name  = name;
            this.price = price;
        }
        
    }
}
