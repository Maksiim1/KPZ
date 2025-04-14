using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class SwordDecorator : HeroDecorator
    {
        public SwordDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return $"{_hero.GetDescription()} + Sword";
        }

        public override int GetAttackPower()
        {
            return _hero.GetAttackPower() + 7;
        }
    }
}
