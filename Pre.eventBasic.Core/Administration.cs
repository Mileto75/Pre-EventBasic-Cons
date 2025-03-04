using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.eventBasic.Core
{
    public class Administration
    {
        //event handler method/implementation
        public void OrderProduct(object sender, StockEventArgs stockEventargs)
        {
            Console.WriteLine($"Stock depleted, ordering {stockEventargs.ItemCount} {stockEventargs.Product}...");
        }
        public void StartPromotion(object sender, StockEventArgs stockEventArgs )
        {
            Console.WriteLine($"Overstock detected, start promotion to sell {stockEventArgs.ItemCount} {stockEventArgs.Product}...");
        }
    }
}
