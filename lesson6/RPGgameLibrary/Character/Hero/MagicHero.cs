using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Hero
{
    public class MagicHero: Hero
    {
        private static List<MagicHero> magicHeroes = new List<MagicHero>();

        private static int health = 100;
        private static int mana = 100;
        private static int maxManaPoint = 100;
        private static int maxHealthPoint = 100;

        private int meleeDamage = 1;
        private int magicDamage = 10;

        public static List<MagicHero> MagicHeroes
        {
            get { return magicHeroes; }
        }

        public MagicHero(string name) : base(name, health, mana, maxManaPoint, maxHealthPoint)
        {
            magicHeroes.Add(this);
        }

        public void StickAttack(BaseHero hero)
        {
            base.MeleeAttack(meleeDamage, hero);
        }

        public void FireBall(BaseHero hero)
        {
            int fireBallPrice = 5;
            base.MagicAttack(magicDamage, fireBallPrice, hero);
        }
    }
}
