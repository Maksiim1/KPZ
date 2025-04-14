using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;
using Task2.Products.Kiaomi;

namespace Task2.Factories
{
    public class KiaomiFactory : IDeviceFactory
    {
        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new KiaomiNetbook();
        }

        public IEBook CreateEBook()
        {
            return new KiaomiEBook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
}
