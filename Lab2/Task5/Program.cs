using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Builders;
using Task5.Director;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var heroBuilder = new HeroBuilder();
            var enemyBuilder = new EnemyBuilder();
            var director = new CharacterDirector();

            var standardHero = director.CreateHero(heroBuilder);
            var standardEnemy = director.CreateEnemy(enemyBuilder);

            var customHero = director.CreateCustomHero(heroBuilder);
            var customEnemy = director.CreateCustomEnemy(enemyBuilder);

            var manualHero = new HeroBuilder()
                .SetName("Lyra")
                .SetHeight(165)
                .SetBuild("Sporty")
                .SetHairColor("Red")
                .SetEyeColor("Green")
                .AddClothing("Leather jacket")
                .AddClothing("Comfortable pants")
                .AddInventoryItem("Twin daggers")
                .AddGoodDeed("Saved a child from a burning house")
                .Build();

            Console.WriteLine("=== Standard Hero ===");
            Console.WriteLine(standardHero);

            Console.WriteLine("=== Standard Enemy ===");
            Console.WriteLine(standardEnemy);

            Console.WriteLine("=== Dream Hero ===");
            Console.WriteLine(customHero);

            Console.WriteLine("=== Fiercest Enemy ===");
            Console.WriteLine(customEnemy);

            Console.WriteLine("=== Manually Created Hero ===");
            Console.WriteLine(manualHero);
        }
    }
}
