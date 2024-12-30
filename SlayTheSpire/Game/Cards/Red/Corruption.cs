using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Corruption : AbstractCard
    {
        static public Corruption Instance { get; } = new Corruption();
        public Corruption() : base("Corruption", 2, CardColor.Red, CardRarity.Rare, CardTarget.Self, CardType.Power)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            Description = """
                能力
                所有技能牌耗能变为0。
                所有技能牌在被打出时被消耗。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.ApplyPower(new CorruptionPower());
            user.DrawPile.ForEach(card =>
            {
                if (card.Type == CardType.Skill)
                {
                    card.Cost = 0;
                    card.IsExhaust = true;
                }
            });
            user.Hand.ForEach(card =>
            {
                if (card.Type == CardType.Skill)
                {
                    card.Cost = 0;
                    card.IsExhaust = true;
                }
            });
            user.DiscardPile.ForEach(card =>
            {
                if (card.Type == CardType.Skill)
                {
                    card.Cost = 0;
                    card.IsExhaust = true;
                }
            });
        }
    }
}
