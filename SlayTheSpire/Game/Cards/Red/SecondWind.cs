using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class SecondWind : AbstractCard
    {
        static public SecondWind Instance { get; } = new SecondWind();
        public SecondWind() : base("SecondWind", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseBlock = 10;
            Description = """
                技能
                消耗手牌中所有非攻击牌，
                每张获得7点格挡。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            List<AbstractCard> cardsToExhaust = new List<AbstractCard>();
            for(int i = 0; i < user.Hand.Count; i++)
            {
                var card = user.Hand[i];
                if (card.Type != CardType.Attack)
                {
                    cardsToExhaust.Add(card);
                    user.AddBlock(BaseBlock);
                    
                }
            }
            for(int i = 0; i < cardsToExhaust.Count; i++)
            {
                user.ExhaustCard(cardsToExhaust[i]);
            }
        }
    }
}
