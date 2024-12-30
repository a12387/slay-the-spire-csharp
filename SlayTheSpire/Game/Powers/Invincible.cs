using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class Invincible : AbstractPower
    {
        public Invincible(int amount) : base("Invincible", amount, PowerType.Buff)
        {

        }
        public override void OnHurt(ref int amount)
        {
            if(amount< Amount)
            {
                Amount -= amount;
            }
            else
            {
                amount = Amount;
                Amount = 0;
            }
        }
        public override void OnTurnStart()
        {
            Amount = 300;
        }
        public override void OnUpdate(AbstractCreature creature, List<AbstractPower> toRemove)
        {
            
        }
    }
}
