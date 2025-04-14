using System;
using Task5.Builders;
using Task5.Models;

namespace Task5.Director
{
    public class CharacterDirector
    {
        public Character CreateHero(HeroBuilder builder)
        {
            return builder
                .SetName("Yaryna Thunderstriker")
                .SetHeight(162)
                .SetBuild("Sinewy")
                .SetHairColor("Ashen-red with a white streak")
                .SetEyeColor("Amber with golden specks")
                .AddClothing("Crow-feather cloak")
                .AddClothing("Seven-league boots")
                .AddInventoryItem("Sword that sings at dawn")
                .AddInventoryItem("Compass of desires")
                .AddGoodDeed("Saved a village from time-thieves")
                .AddGoodDeed("Returned forgotten dreams to children")
                .Build();
        }

        public Character CreateEnemy(EnemyBuilder builder)
        {
            return builder
                .SetName("Crooktooth the Nightwalker")
                .SetHeight(198)
                .SetBuild("Burly with a hunchback")
                .SetHairColor("Pitch-black with living shadows")
                .SetEyeColor("Empty as wells")
                .AddClothing("Cloak of whispers")
                .AddClothing("Gloves made from moonlight skin")
                .AddInventoryItem("Clock that steals memories")
                .AddInventoryItem("Mirror of truth")
                .AddEvilDeed("Collects children's laughter in crystal bottles")
                .AddEvilDeed("Turns stars into ashes")
                .Build();
        }

        public Character CreateCustomHero(HeroBuilder builder)
        {
            return builder
                .SetName("Myroslav Windchaser")
                .SetHeight(170)
                .SetBuild("Thin but wiry")
                .SetHairColor("Gray-haired in his youth")
                .SetEyeColor("Different: left green, right blue")
                .AddClothing("Shirt made from giant oak bark")
                .AddClothing("Hat with an invisible feather")
                .AddInventoryItem("Flute that calms storms")
                .AddInventoryItem("Bag with bottomless depth")
                .AddGoodDeed("Taught wolves and sheep to live together")
                .AddGoodDeed("Heals dreams from nightmares")
                .Build();
        }

        public Character CreateCustomEnemy(EnemyBuilder builder)
        {
            return builder
                .SetName("Lady Mist")
                .SetHeight(185)
                .SetBuild("Thin as a spider's web")
                .SetHairColor("Silver with misty strands")
                .SetEyeColor("Pale, almost transparent")
                .AddClothing("Dress made of silence")
                .AddClothing("Necklace of dew drops")
                .AddInventoryItem("Box that absorbs joy")
                .AddInventoryItem("Fan of oblivion")
                .AddEvilDeed("Collects the last breaths of the dying")
                .AddEvilDeed("Replaces memories of love with emptiness")
                .Build();
        }
    }
}