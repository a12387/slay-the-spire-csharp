using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class VoidCard : AbstractCard
    {
        static public VoidCard Instance { get; } = new VoidCard();
        public VoidCard() : base("Void", 1000, CardColor.Colorless, CardRarity.Special, CardTarget.None, CardType.Status)
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
            player.LoseEnergy(BaseMagicNumber);
        }
        public override void OnTurnEnd(AbstractPlayer player)
        {
            player.ExhaustCard(this);
        }
    }
}
