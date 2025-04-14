using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class PowerRingDecorator : HeroDecorator
    {
        public PowerRingDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return $"{_hero.GetDescription()} + Power Ring";
        }

        public override int GetAttackPower()
        {
            return _hero.GetAttackPower() + 4;
        }

        public override int GetDefense()
        {
            return _hero.GetDefense() + 1;
        }
    }
}
