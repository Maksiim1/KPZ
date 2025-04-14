using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxyEBook : IEBook
    {
        public string GetDescription()
        {
            return "Balaxy EBook - Waterproof e-reader with touch control";
        }
    }
}
