using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class Vulnerable : AbstractPower
    {
        public Vulnerable(int amount) : base("Vulnerable", amount, PowerType.Debuff)
        {
        }
        public override void OnHurt(ref int amount)
        {
            amount = (int)(amount * 1.5);
        }
        public override void OnTurnStart(ref bool loseblock, AbstractPlayer player)
        {
            Amount--;
        }
    }
}
