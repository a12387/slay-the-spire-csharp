using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class BackAttackLeft : AbstractPower
    {
        public BackAttackLeft() : base("BackAttackLeft", 1, PowerType.Buff)
        {
        }
        public override void OnHurt(ref int amount)
        {
            amount = (int)(amount * 1.5);
        }
    }
}
