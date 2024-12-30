using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Dazed : AbstractCard
    {
        static public Dazed Instance { get; } = new Dazed();
        public Dazed() : base("Dazed", 1000, CardColor.Colorless, CardRarity.Special, CardTarget.None, CardType.Status)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = true;
            Description = """
                状态
                不能被打出。
                虚无。
                """;
        }
        public override void OnTurnEnd(AbstractPlayer user)
        {
            user.ExhaustCard(this);
        }
    }
}
