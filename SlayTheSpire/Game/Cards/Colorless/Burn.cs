using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Burn : AbstractCard
    {
        static public Burn Instance { get; } = new Burn();
        public Burn() : base("Burn", 1000, CardColor.Colorless, CardRarity.Special, CardTarget.None, CardType.Status)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 2;
            Description = """
                状态
                不能被打出。
                在你的回合结束时，你受到2点伤害。
                """;
        }
        public override void OnTurnEnd(AbstractPlayer user)
        {
            user.Hurt(BaseDamage);
        }
    }
}
