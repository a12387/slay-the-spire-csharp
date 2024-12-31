using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class Artifact : AbstractPower
    {
        public Artifact(int amount) : base("Artifact", amount, PowerType.Buff)
        {
        }
        public override void OnAppliedDebuff(ref int amount)
        {
            Amount--;
            amount = 0;
        }
    }
}
