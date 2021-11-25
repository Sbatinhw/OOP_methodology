using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Hero
{
    class Healer: Hero
    {
        private static List<Healer> healers = new List<Healer>();

        private static int health = 50;
        private static int mana = 100;
        private static int maxManaPoint = 100;
        private static int maxHealthPoint = 50;

        private int meleeDamage = 1;
        private int magicDamage = 1;

        public static List<Healer> Healers
        {
            get { return healers; }
        }

        public Healer(string name) : base(name, health, mana, maxManaPoint, maxHealthPoint)
        {
            healers.Add(this);
        }

        public void Punch(BaseHero hero)
        {
            base.MeleeAttack(meleeDamage, hero);
        }

        public void Flash(BaseHero hero)
        {
            int flashPrice = 2;
            base.MagicAttack(magicDamage, flashPrice, hero);
        }

        public void Healing(BaseHero hero)
        {
            int healPrice = 5;
            int healValue = 15;
            if(base.manaPoint >= healPrice)
            {
                base.Healing(healValue, hero);
                base.DamageMana(healPrice);
            }
        }
    }
}
