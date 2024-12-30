﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Void : AbstractCard
    {
        static public Void Instance { get; } = new Void();
        public Void() : base("Void", 1000, CardColor.Colorless, CardRarity.Special, CardTarget.None, CardType.Status)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = true;
            BaseMagicNumber = 1;
            Description = """
                状态
                不能被打出。
                抽到这张牌时失去1点能量。
                虚无。
                """;
        }
        public override void OnDrawn(AbstractPlayer player)
        {
            player.loseEnergy(BaseMagicNumber);
        }
    }
}