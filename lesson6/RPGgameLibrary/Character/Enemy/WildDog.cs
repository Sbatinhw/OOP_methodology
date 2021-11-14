using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Enemy
{
    public class WildDog: Enemy
    {
        private static List<WildDog> wildDogs = new List<WildDog>();
        private static int id = 0;

        private static int health = 20;
        private static int mana = 0;
        private static int maxManaPoint = 0;
        private static int maxHealthPoint = 20;

        private int meleeDamage = 5;

        public static List<WildDog> WildDogs
        {
            get { return wildDogs; }
        }

        public WildDog() : base(GenerateName(), health, mana, maxManaPoint, maxHealthPoint)
        {
            wildDogs.Add(this);
        }

        public void DogBite(BaseHero hero)
        {
            base.MeleeAttack(meleeDamage, hero);
        }
        private static string GenerateName()
        {
            id++;
            return $"Дикая собака {id}";
        }

    }
}
