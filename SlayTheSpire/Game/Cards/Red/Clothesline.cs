﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class CLothesline : AbstractCard
    {
        static public CLothesline Instance { get; } = new CLothesline();
        public CLothesline() : base("CLothesline", 2, CardColor.Red, CardRarity.Common, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 14;
            BaseMagicNumber = 3;
            Description = """
                攻击
                造成14点伤害。
                给予3层虚弱。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.Attack(BaseDamage, target);
            target.ApplyPower(new Weak(BaseMagicNumber));
        }
    }
}
