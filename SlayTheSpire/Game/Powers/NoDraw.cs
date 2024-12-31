using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class NoDraw : AbstractPower
    {
        public NoDraw() : base("NoDraw", 1, PowerType.Debuff)
        { 
        }
        public override void OnDrawCard(ref int amount)
        {
            amount = 0;
        }
        public override void OnTurnStart(ref bool loseblock, AbstractPlayer player)
        {
            player.buffList.Remove(this);
        }
    }
}
