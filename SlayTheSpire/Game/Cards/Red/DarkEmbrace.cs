using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class DarkEmbrace : AbstractCard
    {
        static public DarkEmbrace Instance { get; } = new DarkEmbrace();
        public DarkEmbrace() : base("DarkEmbrace", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Power)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseMagicNumber = 1;
            Description = """
                能力
                每当有一张牌被消耗时，抽1张牌。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.ApplyPower(new DarkEmbracePower(BaseMagicNumber));
        }
    }
}
