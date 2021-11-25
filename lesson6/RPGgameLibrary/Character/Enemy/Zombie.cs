using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Enemy
{
    class Zombie: Enemy
    {
        private static List<Zombie> zombies = new List<Zombie>();
        private static int id = 0;

        private static int health = 50;
        private static int mana = 0;
        private static int maxManaPoint = 0;
        private static int maxHealthPoint = 50;

        private int meleeDamage = 15;

        public static List<Zombie> Zombies
        {
            get { return zombies; }
        }

        public Zombie() : base(GenerateName(), health, mana, maxManaPoint, maxHealthPoint)
        {
            zombies.Add(this);
        }

        public void ZombieScratch(BaseHero hero)
        {
            base.MeleeAttack(meleeDamage, hero);
        }
        private static string GenerateName()
        {
            id++;
            return $"Живой мертвец {id}";
        }
    }
}
