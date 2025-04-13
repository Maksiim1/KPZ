using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse
    {
        private readonly List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            products.Remove(product);
        }

        public Product FindProduct(string name)
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
