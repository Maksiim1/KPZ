using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; private set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public Product(string name, Money price, string unit, int quantity, DateTime deliveryDate)
        {
            Name = name;
            Price = price;
            Unit = unit;
            Quantity = quantity;
            LastDeliveryDate = deliveryDate;
        }

        public void DecreasePrice(Money amount)
        {
            if (amount == null)
                throw new ArgumentNullException(nameof(amount));

            Price = Price.Subtract(amount);
        }

        public override string ToString() =>
            $"{Name} - {Quantity} {Unit} - {Price} (Last delivery: {LastDeliveryDate:d})";
    }
}

