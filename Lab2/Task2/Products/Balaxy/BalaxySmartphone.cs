using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxySmartphone : ISmartphone
    {
        public string GetDescription()
        {
            return "Balaxy Smartphone - Smartphone with an innovative design";
        }
    }
}
