using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class FeelNoPain : AbstractCard
    {
        static public FeelNoPain Instance { get; } = new FeelNoPain();
        public FeelNoPain() : base("无惧疼痛", "FeelNoPain", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Power)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseMagicNumber = 4;
            Description = """
                能力
                每当有一张牌被消耗，
                获得4点格挡。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.ApplyPower(new FeelNoPainPower(BaseMagicNumber));
        }
    }
}
