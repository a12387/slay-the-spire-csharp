using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class ShrugItOff : AbstractCard
    {
        static public ShrugItOff Instance { get; } = new ShrugItOff();
        public ShrugItOff() : base("ShrugItOff", 1, CardColor.Red, CardRarity.Common, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseBlock = 11;
            BaseDraw = 1;
            Description = """
                技能
                获得11点格挡。
                抽1张牌。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.AddBlock(BaseBlock);
            user.DrawCard(BaseDraw);
        }
    }
}
