using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class PowerStrength : AbstractPower
    {
        public PowerStrength(int amount) : base("Strength", amount, PowerType.Buff)
        {

        }
        public override void OnAttack(ref int amount)
        {
            amount += Amount;
        }
    }
}
