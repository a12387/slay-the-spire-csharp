using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class BurningPact : AbstractCard
    {
        static public BurningPact Instance { get; } = new BurningPact();
        public BurningPact() : base("BurningPact", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDraw = 3;
            Description = """
                技能
                消耗1张牌。
                抽3张牌。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.DrawCard(BaseDraw);
            //等待选牌操作
        }
    }
}
