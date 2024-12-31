using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Exhume : AbstractCard
    {
        static public Exhume Instance { get; } = new Exhume();
        public Exhume() : base("Exhume", 0, CardColor.Red, CardRarity.Rare, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = true;
            IsEthereal = false;
            Description = """
                技能
                选择一张已消耗的牌，将其放入你的手牌。
                消耗。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            ChooseCardFromGroup(user.ExhaustPile, 1);
        }
        public override void Effect(AbstractPlayer user, AbstractCard card)
        {
            user.ExhaustPile.Remove(card);
            user.AddCardToHand(card);
        }
    }
}
