﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class PowerThrough : AbstractCard
    {
        static public PowerThrough Instance { get; } = new PowerThrough();
        public PowerThrough() : base("硬撑", "PowerThrough", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseBlock = 20;
            Description = """
                技能
                增加2张伤口到你的手牌。
                获得20点格挡。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.AddBlock(BaseBlock);
            user.AddCardsToHand(new List<AbstractCard>() { new Wound(), new Wound() });
        }
    }
}
