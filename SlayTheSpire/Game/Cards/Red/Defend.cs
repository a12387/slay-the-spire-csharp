using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Defend : AbstractCard
    {
        static public Defend Instance { get; } = new Defend();
        public Defend() : base("防御", "Defend", 1, CardColor.Red, CardRarity.Basic, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseBlock = 8;
            Description = """
                技能
                获得8点格挡。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.AddBlock(BaseBlock);
        }
    }
}
