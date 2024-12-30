using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class LimitBreak : AbstractCard
    {
        static public LimitBreak Instance { get; } = new LimitBreak();
        public LimitBreak() : base("LimitBreak", 1, CardColor.Red, CardRarity.Rare, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            Description = """
                技能
                将你的力量翻倍。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.BuffList.ForEach(buff => buff.OnLimitBreak());
        }
    }
}
