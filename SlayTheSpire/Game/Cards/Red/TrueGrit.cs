using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class TrueGrit : AbstractCard
    {
        static public TrueGrit Instance { get; } = new TrueGrit();
        public TrueGrit() : base("TrueGrit", 1, CardColor.Red, CardRarity.Common, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseBlock = 9;
            Description = """
                技能
                获得9点格挡。
                消耗一张手牌。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            ChooseCardFromGroup(user.Hand, 1);
            
            //需要选牌

        }
        public override void Effect(AbstractPlayer user, AbstractCard card)
        {
            user.AddBlock(BaseBlock);
            user.ExhaustCard(card);
        }
    }
}
