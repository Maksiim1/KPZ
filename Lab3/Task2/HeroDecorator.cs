using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero _hero;

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetDescription()
        {
            return _hero.GetDescription();
        }

        public virtual int GetAttackPower()
        {
            return _hero.GetAttackPower();
        }

        public virtual int GetDefense()
        {
            return _hero.GetDefense();
        }

        public virtual int GetMagicPower()
        {
            return _hero.GetMagicPower();
        }
    }
}
