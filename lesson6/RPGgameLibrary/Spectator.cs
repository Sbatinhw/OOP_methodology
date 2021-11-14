using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGgameLibrary.Character.Enemy;
using RPGgameLibrary.Character.Hero;
using RPGgameLibrary.Character.Npc;

namespace RPGgameLibrary
{
    class Spectator
    {
        private List<string> log;
        DateTime lastAsk;
        double secondsForAsk = 10;

        public Spectator()
        {
            lastAsk = DateTime.Now;
            log = new List<string>();
        }
        public void AskLogs()
        {
            foreach(var n in WildDog.WildDogs)
            {
                log.AddRange(n.Log.SendLog());
            }
            foreach (var n in Zombie.Zombies)
            {
                log.AddRange(n.Log.SendLog());
            }
            foreach (var n in Healer.Healers)
            {
                log.AddRange(n.Log.SendLog());
            }
            foreach (var n in MagicHero.MagicHeroes)
            {
                log.AddRange(n.Log.SendLog());
            }
            foreach (var n in WarriorHero.WarriorHeroes)
            {
                log.AddRange(n.Log.SendLog());
            }
            foreach (var n in Guard.Guards)
            {
                log.AddRange(n.Log.SendLog());
            }
        }
        public void PrintLog()
        {
            foreach(var n in log)
            {
                Console.WriteLine(n);
            }
        }
    }
}
