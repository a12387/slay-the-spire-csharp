using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class BeatOfDeath : AbstractPower
    {
        public BeatOfDeath(int amount) : base("BeatOfDeath", amount, PowerType.Buff)
        {
        }
        public override void OnUseCard(AbstractPlayer player)
        {
            player.Hurt(this.Amount);
        }
    }
}
