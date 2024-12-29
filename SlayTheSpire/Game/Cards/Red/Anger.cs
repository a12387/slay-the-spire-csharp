using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Anger : AbstractCard
    {
        static public Anger Instance { get; } = new Anger();
        public Anger() : base("Anger", 0, CardColor.Red, CardRarity.Common, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 8;
            Description = """
                攻击
                造成8点伤害。
                在弃牌堆放入一张此牌的复制品。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.Attack(BaseDamage, target);
            user.DiscardPile.Add(new Anger());
        }
    }
}
