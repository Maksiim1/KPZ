using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Paladin : Hero
    {
        public Paladin(string name) : base(name) { }

        public override string GetDescription()
        {
            return $"Paladin {base.GetDescription()}";
        }

        public override int GetAttackPower()
        {
            return 8;
        }

        public override int GetDefense()
        {
            return 10;
        }

        public override int GetMagicPower()
        {
            return 5;
        }
    }
}
