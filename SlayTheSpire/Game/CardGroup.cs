using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    enum CardGroupType
    {
        MasterDeck,
        DrawPile,
        Hand,
        DiscardPile,
        ExhaustPile
    };
    internal class CardGroup : List<AbstractCard>
    {
        public CardGroupType Type { get; }
        public CardGroup(CardGroupType type) 
        { 
            Type = type;
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int i = Count - 1; i >= 0; i--)
            {
                var card1 = this[i];
                var card2 = this[rnd.Next(i + 1)];
                (card1, card2) = (card2, card1);
            }
        }
    }
}
