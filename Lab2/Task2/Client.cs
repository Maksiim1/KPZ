using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2
{
    public class Client
    {
        private IDeviceFactory _factory;

        public Client(IDeviceFactory factory)
        {
            _factory = factory;
        }

        public void CreateDevices()
        {
            ILaptop laptop = _factory.CreateLaptop();
            INetbook netbook = _factory.CreateNetbook();
            IEBook eBook = _factory.CreateEBook();
            ISmartphone smartphone = _factory.CreateSmartphone();

            Console.WriteLine(laptop.GetDescription());
            Console.WriteLine(netbook.GetDescription());
            Console.WriteLine(eBook.GetDescription());
            Console.WriteLine(smartphone.GetDescription());
        }
    }
}
