using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Factories;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== IProne products ===");
            Client iProneClient = new Client(new IProneFactory());
            iProneClient.CreateDevices();

            Console.WriteLine("\n=== Kiaomi products ===");
            Client kiaomiClient = new Client(new KiaomiFactory());
            kiaomiClient.CreateDevices();

            Console.WriteLine("\n=== Balaxy products ===");
            Client balaxyClient = new Client(new BalaxyFactory());
            balaxyClient.CreateDevices();

            Console.ReadKey();
        }
    }
}
