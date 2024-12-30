using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class Frail : AbstractPower//脆弱
    {
        public Frail(int amount) : base("Frail", amount, PowerType.Debuff)
        {
        }
        public override void OnAddBlock(ref int amount, int order)
        {
            if (order == 2) amount = (int)(amount * 0.75);
        }
        public override void OnTurnStart(ref bool loseblock, AbstractPlayer player)
        {
            Amount--;
        }
        public override void OnTurnStart()
        {
            Amount--;
        }

    }
}
