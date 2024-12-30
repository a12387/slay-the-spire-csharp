using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Wound : AbstractCard
    {
        static public Wound Instance { get; } = new Wound();
        public Wound() : base("Wound", 1000, CardColor.Colorless, CardRarity.Special, CardTarget.None, CardType.Status)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            Description = """
                状态
                不能被打出。
                """;
        }
    }
}
