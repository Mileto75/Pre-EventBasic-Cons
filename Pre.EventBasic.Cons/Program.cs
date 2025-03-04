// See https://aka.ms/new-console-template for more information
using Pre.eventBasic.Core;

Console.WriteLine("Stock inventory app");
var productInventory = new ProductInventory { Product = "Potjes Chocomouse", ItemsInStock = 20 };
var administration = new Administration();
//couple event handler method to event
productInventory.ProductShortageStockHandler += administration.OrderProduct;
productInventory.ProductOverstockStockHandler += administration.StartPromotion;
Simulate();

void Simulate()
{
    var random = new Random();
    for(int i = 0;i<20;i++)
    {
        productInventory.Sell(random.Next(0, 5));
        productInventory.Buy(random.Next(0, 20));
        Thread.Sleep(300);
    }
}
