using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Slimed : AbstractCard
    {
        static public Slimed Instance { get; } = new Slimed();
        public Slimed() : base("Slimed", 1, CardColor.Colorless, CardRarity.Special, CardTarget.None, CardType.Status)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            Description = """
                状态
                消耗。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.ExhaustCard(this);
        }
    }
}
