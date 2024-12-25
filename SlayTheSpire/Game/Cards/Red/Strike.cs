using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Strike : AbstractCard
    {
        static public Strike Instance { get; } = new Strike();
        public Strike() : base("Strike", 1, CardColor.Red, CardRarity.Basic, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 6;
            Description = """
                攻击
                造成6点伤害。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.Attack(BaseDamage, target);
        }
    }
}
