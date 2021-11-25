using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGgameLibrary;

namespace RPGgameLibrary.Character
{
    public abstract class BaseHero
    {
        protected int healthPoint;
        protected int manaPoint;
        protected int maxMana;
        protected int maxHealth;
        protected string name;

        protected Log heroLog;

        public Log Log
        {
            get { return heroLog; }
        }

        protected BaseHero(
            int healthPoint,
            int manaPoint,
            int maxMana,
            int maxHealth,
            string name
            )
        {
            this.healthPoint = healthPoint;
            this.manaPoint = manaPoint;
            this.maxHealth = maxHealth;
            this.maxMana = maxMana;
            this.name = name;

            heroLog = new Log();
            heroLog.AddLog($"{name} создан");
        }

        protected void MeleeAttack(int damage, BaseHero hero)
        {
            hero.DamageHeal(damage);
            heroLog.AddLog($"{name} атакует {hero.name}");
        }

        protected void MagicAttack(int damage, int price, BaseHero hero)
        {
            if(price > manaPoint) { return; }
            manaPoint -= price;
            hero.DamageHeal(damage);
            heroLog.AddLog($"{name} атакует {hero.name}");
        }

        protected void Healing(int heal)
        {
            if (heal < 0) { return; }
            else if (healthPoint + heal > maxHealth) { healthPoint = maxHealth; }
            else { healthPoint += heal; }
            heroLog.AddLog($"{name} восстанавливает {heal}hp");
        }

        protected void Healing(int heal, BaseHero hero)
        {
            hero.Healing(heal);
            heroLog.AddLog($"{name} лечит {hero.name}");
        }

        protected void RestoreMana(int mana)
        {
            if (mana < 0) { return; }
            else if(manaPoint + mana > maxMana) { manaPoint = maxMana; }
            else { manaPoint += mana; }
            heroLog.AddLog($"{name} восстанавливает {mana}hp");
        }

        protected void RestoreMana(int mana, BaseHero hero)
        {
            hero.RestoreMana(mana);
            heroLog.AddLog($"{name} восстанавливает ману {hero.name}");
        }

        protected void DamageHeal(int damage)
        {
            if (damage < 0) { return; }
            else if (damage >= healthPoint) { healthPoint = 0; }
            else if (damage <= healthPoint) { healthPoint -= damage; }
            heroLog.AddLog($"{name} теряет {damage}hp");
        }

        protected void DamageMana(int damage)
        {
            if (damage < 0) { return; }
            else if (damage >= manaPoint) { manaPoint = 0; }
            else if (damage <= manaPoint) { manaPoint -= damage; }
            heroLog.AddLog($"{name} теряет {damage}mp");
        }

        protected string Status()
        {
            return $"Health: {healthPoint}/{maxHealth}\nMana: {manaPoint}/{maxMana}";
        }

    }
}
