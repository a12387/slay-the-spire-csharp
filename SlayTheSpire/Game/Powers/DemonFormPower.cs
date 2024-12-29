using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class DemonFormPower : AbstractPower
    {
        public DemonFormPower(int amount) : base("DemonFormPower", amount, PowerType.Buff)
        {
        }
        public override void OnTurnStart(ref bool loseblock, AbstractPlayer player)
        {
            player.ApplyPower(new Strength(this.Amount));
        }
    }
}
