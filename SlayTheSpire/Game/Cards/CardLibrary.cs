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
        static public Bitmap GetCardImage(string name)
        {
            return CardImages[name];
        }
    }
}
