using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Inflame : AbstractCard
    {
        static public Inflame Instance { get; } = new Inflame();
        public Inflame() : base("Inflame", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Power)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseMagicNumber = 3;
            Description = """
                能力
                获得3点力量。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.ApplyPower(new Strength(BaseMagicNumber));
        }
    }
}
