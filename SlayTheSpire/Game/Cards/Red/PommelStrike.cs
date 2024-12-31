using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class PommelStrike : AbstractCard
    {
        static public PommelStrike Instance { get; } = new PommelStrike();
        public PommelStrike() : base("剑柄打击", "PommelStrike", 1, CardColor.Red, CardRarity.Common, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 10;
            BaseDraw = 2;
            Description = """
                攻击
                造成10点伤害。
                抽2张牌。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            if (target != null)
            {
                user.Attack(BaseDamage, target);
                user.DrawCard(BaseDraw);
            }
        }
    }
}
