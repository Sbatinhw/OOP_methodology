using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Npc
{
    class Npc: BaseHero
    {
        public string Name
        {
            get { return base.name; }
        }
        protected Npc(
            string name,
            int healthPoint,
            int manaPoint,
            int maxMana,
            int maxHealth
            ) : base(
                healthPoint,
                manaPoint,
                maxMana,
                maxHealth,
                name
            )
        {

        }
    }
}
