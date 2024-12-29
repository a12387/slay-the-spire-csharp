﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Powers
{
    internal class BarricadePower : AbstractPower
    {
        public BarricadePower() : base("BarricadePower", 1, PowerType.Buff)
        {
        }
        public override void OnTurnStart(ref bool loseblock, AbstractPlayer player)
        {
            loseblock = false;
        }
    }
}
