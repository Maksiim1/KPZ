using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class HelmetDecorator : HeroDecorator
    {
        public HelmetDecorator(IHero hero) : base(hero) { }

        public override string GetDescription()
        {
            return $"{_hero.GetDescription()} + Helmet";
        }

        public override int GetDefense()
        {
            return _hero.GetDefense() + 3;
        }
    }
}
