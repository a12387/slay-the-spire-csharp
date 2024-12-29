using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class BodeSlam : AbstractCard
    {
        static public BodeSlam Instance { get; } = new BodeSlam();
        public BodeSlam() : base("BodeSlam", 0, CardColor.Red, CardRarity.Common, CardTarget.Enemy, CardType.Attack)
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
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.Attack(user.CurrentBlock, target);
        }
    }
}
