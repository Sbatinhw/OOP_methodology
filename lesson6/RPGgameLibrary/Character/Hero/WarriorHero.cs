using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Hero
{
    public class WarriorHero: Hero
    {
        private static List<WarriorHero> warriorHeroes = new List<WarriorHero>();

        private static int health = 100;
        private static int mana = 10;
        private static int maxManaPoint = 10;
        private static int maxHealthPoint = 100;

        private int meleeDamage = 5;
        private int magicDamage = 1;

        public static List<WarriorHero> WarriorHeroes
        {
            get { return warriorHeroes; }
        }

        public WarriorHero(string name): base(name, health, mana, maxManaPoint, maxHealthPoint)
        {
            warriorHeroes.Add(this);
        }

        public void SwordAttack(BaseHero hero)
        {
            base.MeleeAttack(meleeDamage, hero);
        }

        public void MagicKnifeAttack(BaseHero hero)
        {
            int magicKnifeAttackPrice = 1;
            base.MeleeAttack(meleeDamage, hero);
            base.MagicAttack(magicDamage, magicKnifeAttackPrice, hero);
        }
    }
}
