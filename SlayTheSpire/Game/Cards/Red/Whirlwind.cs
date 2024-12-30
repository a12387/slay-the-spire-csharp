using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Whirlwind : AbstractCard
    {
        static public Whirlwind Instance { get; } = new Whirlwind();
        public Whirlwind() : base("Whirlwind", -1, CardColor.Red, CardRarity.Uncommon, CardTarget.AllEnemies, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 8;
            Description = """
                攻击
                对所有敌人造成8点伤害X次。
                """;
        }
        public override void OnUse(AbstractPlayer user, List<AbstractMonster> targets)
        {
            int times = user.Energy;
            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < targets.Count; j++)
                {
                    int oldCount = targets.Count;
                    user.Attack(BaseDamage, targets[j]);
                    if (targets.Count != oldCount) // Someone died
                    {
                        j--;
                    }
                }
            }
        }
    }
}
