using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name) { }

        public override string GetDescription()
        {
            return $"Mage {base.GetDescription()}";
        }

        public override int GetAttackPower()
        {
            return 3;
        }

        public override int GetDefense()
        {
            return 3;
        }

        public override int GetMagicPower()
        {
            return 15;
        }
    }
}
