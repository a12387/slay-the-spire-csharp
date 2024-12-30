using SlayTheSpire.Game.Powers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Barricade : AbstractCard
    {
        static public Barricade Instance { get; } = new Barricade();
        public Barricade() : base("Barricade", 3, CardColor.Red, CardRarity.Rare, CardTarget.Self, CardType.Power)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            Description = """
                能力
                格挡不再在你的回合开始时消失。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.ApplyPower(new BarricadePower());
        }
    }
}
