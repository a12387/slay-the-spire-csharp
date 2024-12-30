using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Bash : AbstractCard
    {
        static public Bash Instance { get; } = new Bash();
        public Bash() : base("Bash", 2, CardColor.Red, CardRarity.Basic, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 10;
            BaseMagicNumber = 3;
            Description = """
                攻击
                造成10点伤害。
                给予3层易伤。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            if (target != null)
            {
                user.Attack(BaseDamage, target);
                target.ApplyPower(new Vulnerable(BaseMagicNumber));
            }
        }
    }
}
