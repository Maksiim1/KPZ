using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Products.IProne
{
    public class IProneSmartphone : ISmartphone
    {
        public string GetDescription()
        {
            return "IProne Smartphone - The latest smartphone with a powerful camera";
        }
    }
}
