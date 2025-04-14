using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Interfaces;
using Task5.Models;

namespace Task5.Builders
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new Character { IsHero = true };

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(int height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder AddClothing(string clothing)
        {
            _character.Clothing.Add(clothing);
            return this;
        }

        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder AddGoodDeed(string deed)
        {
            _character.Deeds.Add(deed);
            return this;
        }

        public Character Build()
        {
            return _character;
        }

        public ICharacterBuilder AddEvilDeed(string deed)
        {
            return this;
        }

    }
}
