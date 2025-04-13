using ClassLibrary;
using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            var money = new Money(10, 50);
            Console.WriteLine($"Initial price: {money}");

            var apple = new Product("Apple", new Money(5, 0), "kg", 100, DateTime.Now);
            apple.DecreasePrice(new Money(1, 50));
            Console.WriteLine($"Discounted price: {apple.Price}");

            var warehouse = new Warehouse();
            warehouse.AddProduct(apple);

            var reporting = new Reporting(warehouse);
            reporting.Incoming(apple, 50);
            reporting.Outgoing(apple, 20);
            reporting.InventoryReport();
        }
    }
}
