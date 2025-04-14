using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IHero
    {
        string GetDescription();
        int GetAttackPower();
        int GetDefense();
        int GetMagicPower();
    }

    public abstract class Hero : IHero
    {
        protected string Name { get; set; }

        public Hero(string name)
        {
            Name = name;
        }

        public virtual string GetDescription()
        {
            return Name;
        }

        public abstract int GetAttackPower();
        public abstract int GetDefense();
        public abstract int GetMagicPower();
    }
}
