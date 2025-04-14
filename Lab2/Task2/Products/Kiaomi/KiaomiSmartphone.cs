using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Products.Kiaomi
{
    public class KiaomiSmartphone : ISmartphone
    {
        public string GetDescription()
        {
            return "Kiaomi Smartphone - The best price/quality ratio";
        }
    }
}
