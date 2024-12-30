using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class Bludgeon : AbstractCard
    {
        static public Bludgeon Instance { get; } = new Bludgeon();
        public Bludgeon() : base("Bludgeon", 3, CardColor.Red, CardRarity.Rare, CardTarget.Enemy, CardType.Attack)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseDamage = 42;
            Description = """
                攻击
                造成42点伤害。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            user.Attack(BaseDamage, target);
        }
    }
}
