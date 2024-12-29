using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class FeelNoPainPower : AbstractPower
    {
        public FeelNoPainPower(int amount) : base("FeelNoPainPower", amount, PowerType.Buff)
        {
        }
        public override void OnExhaustCard(AbstractPlayer player)
        {
            player.AddBlock(this.Amount);
        }
    }
}
