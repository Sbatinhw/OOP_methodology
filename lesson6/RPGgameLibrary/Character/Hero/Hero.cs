using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGgameLibrary.Character.Hero
{
    public abstract class Hero: BaseHero
    {
        public string NickName 
        {
            get { return base.name; }
        }

        protected Hero(
            string name,
            int healthPoint,
            int manaPoint,
            int maxMana,
            int maxHealth
            ): base(
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
