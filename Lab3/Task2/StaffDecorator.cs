using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class StaffDecorator : HeroDecorator
    {
        public StaffDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return $"{_hero.GetDescription()} + Staff";
        }

        public override int GetAttackPower()
        {
            return _hero.GetAttackPower() + 2;
        }

        public override int GetMagicPower()
        {
            return _hero.GetMagicPower() + 8;
        }
    }
}
