﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class DarkEmbracePower : AbstractPower
    {
        public DarkEmbracePower(int amount) : base("DarkEmbracePower", amount, PowerType.Buff)
        {
        }
        public override void OnExhaustCard(AbstractPlayer player)
        {
            player.DrawCard(this.Amount);
        }
    }
}
