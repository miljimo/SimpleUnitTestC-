using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout
{
    public class CheckOutService : Service, TryCount, TryAdd<String>, TryEmpty<bool>
    {
        private List<StockItem> items;

        public CheckOutService()
        {
            this.items = new List<StockItem>();
        }

        //purchase a single item
        public double purchase(string name, int units)
        {
            var result = 0.0;
            for(var i=0; i < this.items.Count; i++)
            {
                var item = this.items.ElementAt(i);
                if (item.name.Trim().ToLower().Equals(name.Trim().ToLower()))
                {
                    result = item.price * units;
                    break;
                }
            }
            return result;
        }

        //add a stock item to service object
        public bool add(String name, double price)
        {
            if (!this.exists(name) && name.Trim().Length>0)
            {
                var item = new StockItem(name, price);
                this.items.Add(item);
                return true;
            }
            return false;
        }

     public bool empty()
        {
            var isempt = false;
            this.items.Clear();
            if (this.items.Count() == 0)
                isempt= true;
            return isempt;
        }
    public int count()
        {
            return this.items.Count();
        }

    private bool exists(String name)
        {
            for (int i = 0; i < this.items.Count(); i++)
            {
                var temItem = this.items.ElementAt(i);
                if (temItem.name.Trim().ToLower().Equals(name.Trim().ToLower()))
                {
                    return true;
                }

            }
            return false;
        }

        //purchase a list of items
    public double purchaseRange(Array list)
        {
            var result = 0.0;

            for(var i=0; i < list.Length; i++)
            {
                var item =(Item) list.GetValue(i);
                result += this.purchase(item.name, item.units);
            }
            return result;
        }

    }
}
