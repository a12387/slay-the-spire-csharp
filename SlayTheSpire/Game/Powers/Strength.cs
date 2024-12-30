using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class Strength : AbstractPower
    {
        public Strength(int amount) : base("Strength", amount, PowerType.Buff)
        {

        }
        public override void OnAttack(ref int amount, int order)
        {
            if(order==1)amount += Amount;
        }
        public override void OnLimitBreak()
        {
            Amount *= 2;
        }
    }
}
