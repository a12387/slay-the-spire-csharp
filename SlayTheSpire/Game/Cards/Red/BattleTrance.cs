using SlayTheSpire.Game.Powers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class BattleTrance : AbstractCard
    {
        static public BattleTrance Instance { get; } = new BattleTrance();
        public BattleTrance() : base("BattleTrance", 0, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDraw = 4;
            Description = """
                技能
                抽4张牌。
                你在这个回合内不能再抽任何牌。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.DrawCard(BaseDraw);
            user.ApplyPower(new NoDraw());
        }
    }
}
