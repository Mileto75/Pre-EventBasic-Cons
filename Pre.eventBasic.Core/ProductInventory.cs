using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Pre.eventBasic.Core
{
    public class ProductInventory
    {
        public string Product { get; set; }
        public int ItemsInStock { get; set; }

        //delegate type
        public delegate void ProductStockDelegate(object sender, StockEventArgs stockEventargs);

        //event type
        public event ProductStockDelegate ProductShortageStockHandler;
        public event ProductStockDelegate ProductOverstockStockHandler;
        
        public void Buy(int numOfItems)
        {
            ItemsInStock += numOfItems;
            Console.WriteLine($"Bought {numOfItems} of {Product}");
            if(ItemsInStock > 20)
            {
                ProductOverstockStockHandler.Invoke(this, new StockEventArgs {ItemCount = ItemsInStock, Product = Product });
            }
        }
        public void Sell(int numOfItems)
        {
            Console.WriteLine($"Sold {numOfItems} of {Product}");
            if (ItemsInStock < numOfItems)
            {
                //problem => order new items
                //invoke the event
                //or raise the event
                ProductShortageStockHandler.Invoke(this, new StockEventArgs { ItemCount = 20, Product = Product });
            }
            ItemsInStock = Math.Max(0, ItemsInStock - numOfItems);
        }
    }
}
