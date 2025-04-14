using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public List<string> Clothing { get; set; } = new List<string>();
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Deeds { get; set; } = new List<string>();
        public bool IsHero { get; set; }

        public override string ToString()
        {
            string characterType = IsHero ? "Hero" : "Enemy";

            string result = $"{characterType}: {Name}\n";
            result += $"Height: {Height} cm\n";
            result += $"Build: {Build}\n";
            result += $"Hair color: {HairColor}\n";
            result += $"Eye color: {EyeColor}\n";

            result += "Clothing:\n";
            foreach (var item in Clothing)
            {
                result += $"- {item}\n";
            }

            result += "Inventory:\n";
            foreach (var item in Inventory)
            {
                result += $"- {item}\n";
            }

            result += "Deeds:\n";
            foreach (var deed in Deeds)
            {
                result += $"- {deed}\n";
            }

            return result;
        }
    }
}
