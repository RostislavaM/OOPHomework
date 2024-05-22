using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class secondArena
    {
        public Hero HeroC { get; private set; }

        public Hero HeroD { get; private set; }

        public GameEventListener EventListener { get; set; }

        public secondArena(Hero c, Hero d)
        {
            HeroC = c;
            HeroD = d;
        }

        public Hero secondBattle()
        {
            Hero attackerB, defenderB;
            attackerB = HeroC;
            defenderB = HeroD;
            while (true)
            {
                int damage = attackerB.Attack();
                defenderB.TakeDamage(damage);

                if (EventListener != null)
                {
                    EventListener.GameRound2(attackerB, defenderB, damage);
                }

                if (defenderB.IsDead) return attackerB;

                Hero temp = attackerB;
                attackerB = defenderB;
                defenderB = temp;
            }
        }
    }
}
