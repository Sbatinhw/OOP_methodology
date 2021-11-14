using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Npc
{
    class Guard: Npc
    {
        private static List<Guard> guards = new List<Guard>();
        private static int id = 0;

        private static int health = 100;
        private static int mana = 0;
        private static int maxManaPoint = 0;
        private static int maxHealthPoint = 100;

        private int meleeDamage = 5;

        public static List<Guard> Guards
        {
            get { return guards; }
        }

        public Guard() : base(GenerateName(), health, mana, maxManaPoint, maxHealthPoint)
        {
            guards.Add(this);
        }

        public void RandomPhrase()
        {
            List<string> phrases = new List<string>();
            phrases.Add("Уходи");
            phrases.Add("Не вмешивайся");
            phrases.Add("Снегодождь");

            Random random = new Random();
            int phrase = random.Next(0, phrases.Count());
            Console.WriteLine(phrases[phrase]);
        }

        protected new void DamageHeal(int damage)
        {
            
        }

        private static string GenerateName()
        {
            id++;
            return $"Стражник {id}";
        }
    }
}
