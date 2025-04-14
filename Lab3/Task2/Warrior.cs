using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name) { }

        public override string GetDescription()
        {
            return $"Warrior {base.GetDescription()}";
        }

        public override int GetAttackPower()
        {
            return 10;
        }

        public override int GetDefense()
        {
            return 8;
        }

        public override int GetMagicPower()
        {
            return 1;
        }
    }
}
