using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    //- Has a 30% chance to avoid damage completely.
    //- Has a 30% chance to cause damage equal to 3 times his Strength.
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 30)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 30)
            {
                baseAttack = Strength * 3;
            }
            return baseAttack;
        }
    }
}
