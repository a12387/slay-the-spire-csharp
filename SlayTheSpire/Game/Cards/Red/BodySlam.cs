using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class BodySlam : AbstractCard
    {
        static public BodySlam Instance { get; } = new BodySlam();
        public BodySlam() : base("BodySlam", 0, CardColor.Red, CardRarity.Common, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            Description = """
                攻击
                造成你当前格挡值的伤害。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            if (target != null)
            {
                user.Attack(user.CurrentBlock, target);
            }
        }
    }
}
