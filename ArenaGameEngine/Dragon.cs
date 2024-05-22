using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Dragon : Hero
    {
        // Has a 35% chance to avoid damage completely.
        // Every 3 hits can cause double damage.
        public Dragon() : this("Draco") 
        {

        }
        public Dragon(string name) : base(name)
        {
            hitCount = 0;
        }

        private int hitCount;

        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 35)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            hitCount = hitCount + 1;
            int baseAttack = base.Attack();
            if (hitCount == 3)
            {
                baseAttack = baseAttack * 2;
                hitCount = 0;
            }
            return baseAttack;
        }
    }
}
