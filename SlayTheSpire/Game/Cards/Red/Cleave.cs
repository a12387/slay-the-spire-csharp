using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Cleave : AbstractCard
    {
        static public Cleave Instance { get; } = new Cleave();
        public Cleave() : base("Cleave", 1, CardColor.Red, CardRarity.Common, CardTarget.AllEnemies, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 11;
            Description = """
                攻击
                对所有敌人造成11点伤害。
                """;
        }
        public override void OnUse(AbstractPlayer user, List<AbstractMonster> targets)
        {
            targets.ForEach(target => user.Attack(BaseDamage, target));
        }
    }
}
