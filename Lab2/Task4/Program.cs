using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus grandfather = new Virus("Covid-1", "Coronavirus", 0.85, 730);

            Virus father1 = new Virus("Covid-2-Alpha", "Coronavirus", 0.77, 365);
            Virus father2 = new Virus("Covid-2-Beta", "Coronavirus", 0.82, 350);

            grandfather.AddChild(father1);
            grandfather.AddChild(father2);

            Virus child1 = new Virus("Covid-3-Omicron", "Coronavirus", 0.65, 120);
            Virus child2 = new Virus("Covid-3-Delta", "Coronavirus", 0.71, 110);
            Virus child3 = new Virus("Covid-3-Gamma", "Coronavirus", 0.68, 115);

            father1.AddChild(child1);
            father1.AddChild(child2);
            father2.AddChild(child3);

            Console.WriteLine("=== ORIGINAL VIRUS FAMILY ===");
            grandfather.DisplayInfo();

            Virus clonedGrandfather = (Virus)grandfather.Clone();

            clonedGrandfather.Name += "-Clone";
            clonedGrandfather.Age += 5;

            if (clonedGrandfather.Children.Count > 0)
            {
                clonedGrandfather.Children[0].Name += "-Modified";
            }

            Console.WriteLine("=== CLONED VIRUS FAMILY ===");
            clonedGrandfather.DisplayInfo();

            Console.WriteLine("=== VERIFICATION OF ORIGINAL FAMILY ===");
            grandfather.DisplayInfo();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
