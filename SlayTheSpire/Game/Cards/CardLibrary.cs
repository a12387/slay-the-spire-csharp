using SlayTheSpire.Game.Cards.Red;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards
{
    internal static class CardLibrary
    {
        static private Dictionary<string, Bitmap> CardImages = new Dictionary<string, Bitmap>()
        {
            ["Strike"] = Properties.Resources.strike,
        };
        static private List<AbstractCard> Cards = new List<AbstractCard>()
        {
            Strike.Instance
        };
        static public Bitmap GetCardImage(string name)
        {
            return CardImages[name];
        }
        static public List<AbstractCard> GetRandomCards(int num)
        {
            List<AbstractCard> cards = new List<AbstractCard>();
            Random rnd = new Random();
            while(num > 0)
            {
                AbstractCard card = Cards[rnd.Next(Cards.Count)];
                //if (cards.Contains(card))
                //    continue;
                //else
                {
                    cards.Add(card);
                    num--;
                }
            }
            return cards;
        }
    }
}
