using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Products.IProne
{
    public class IProneNetbook : INetbook
    {
        public string GetDescription()
        {
            return "IProne Netbook - Compact and powerful";
        }
    }
}
