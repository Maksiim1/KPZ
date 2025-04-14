using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== RPG Decorator Pattern Demo ===\n");

            IHero warrior = new Warrior("Arthur");
            IHero mage = new Mage("Merlin");
            IHero paladin = new Paladin("Galahad");

            PrintHeroStats(warrior);
            PrintHeroStats(mage);
            PrintHeroStats(paladin);

            Console.WriteLine("\n=== Adding Equipment to Heroes ===\n");

            warrior = new ArmorDecorator(warrior);
            warrior = new HelmetDecorator(warrior);
            warrior = new SwordDecorator(warrior);
            PrintHeroStats(warrior);

            mage = new StaffDecorator(mage);
            mage = new AmuletDecorator(mage);
            PrintHeroStats(mage);

            paladin = new ArmorDecorator(paladin);
            paladin = new SwordDecorator(paladin);
            paladin = new PowerRingDecorator(paladin);
            paladin = new AmuletDecorator(paladin);
            PrintHeroStats(paladin);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintHeroStats(IHero hero)
        {
            Console.WriteLine($"Hero: {hero.GetDescription()}");
            Console.WriteLine($"Attack: {hero.GetAttackPower()}, Defense: {hero.GetDefense()}, Magic: {hero.GetMagicPower()}\n");
        }
    }
}
