using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        private readonly Warehouse _warehouse;

        public Reporting(Warehouse warehouse)
        {
            _warehouse = warehouse ?? throw new ArgumentNullException(nameof(warehouse));
        }

        public void Incoming(Product product, int quantity)
        {
            Console.WriteLine($"[INCOMING] {quantity} x {product.Name} on {DateTime.Now:d}");
        }

        public void Outgoing(Product product, int quantity)
        {
            Console.WriteLine($"[OUTGOING] {quantity} x {product.Name} on {DateTime.Now:d}");
        }

        public void InventoryReport()
        {
            Console.WriteLine("--- Inventory Report ---");
            foreach (var product in _warehouse.GetAllProducts())
                Console.WriteLine(product);
        }
    }
}

