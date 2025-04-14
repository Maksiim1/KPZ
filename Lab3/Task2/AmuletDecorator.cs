using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class AmuletDecorator : HeroDecorator
    {
        public AmuletDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return $"{_hero.GetDescription()} + Magic Amulet";
        }

        public override int GetMagicPower()
        {
            return _hero.GetMagicPower() + 6;
        }
    }
}
