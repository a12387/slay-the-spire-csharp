using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Offering : AbstractCard
    {
        static public Offering Instance { get; } = new Offering();
        public Offering() : base("Offering", 0, CardColor.Red, CardRarity.Rare, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = true;
            IsEthereal = false;
            BaseDamage = 6;
            BaseMagicNumber = 2;
            BaseDraw = 5;
            Description = """
                技能
                失去6点生命。
                获得2点能量。
                抽5张牌。
                消耗。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.LoseHealth(BaseDamage);
            user.Energy += BaseMagicNumber;
            user.DrawCard(BaseDraw);
        }
    }
}
