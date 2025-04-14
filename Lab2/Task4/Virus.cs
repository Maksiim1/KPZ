using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus()
        {
            Children = new List<Virus>();
        }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public object Clone()
        {
            Virus clone = (Virus)this.MemberwiseClone();

            clone.Children = new List<Virus>();

            foreach (var child in this.Children)
            {
                clone.Children.Add((Virus)child.Clone());
            }

            return clone;
        }

        public void DisplayInfo(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 4);
            Console.WriteLine($"{indent}Virus: {Name}");
            Console.WriteLine($"{indent}Species: {Species}");
            Console.WriteLine($"{indent}Weight: {Weight} ng");
            Console.WriteLine($"{indent}Age: {Age} days");

            if (Children.Count > 0)
            {
                Console.WriteLine($"{indent}Children ({Children.Count}):");
                foreach (var child in Children)
                {
                    child.DisplayInfo(indentLevel + 1);
                }
            }
            else
            {
                Console.WriteLine($"{indent}Children: none");
            }
            Console.WriteLine();
        }
    }
}
