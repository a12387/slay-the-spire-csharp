using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class DemonForm : AbstractCard
    {
        static public DemonForm Instance { get; } = new DemonForm();
        public DemonForm() : base("DemonForm", 3, CardColor.Red, CardRarity.Rare, CardTarget.Self, CardType.Power)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseMagicNumber = 3;
            Description = """
                能力
                在每回合开始时获得3点力量。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.ApplyPower(new DemonFormPower(BaseMagicNumber));
        }
    }
}
