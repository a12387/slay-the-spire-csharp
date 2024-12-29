using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class BloodLetting : AbstractCard
    {
        static public BloodLetting Instance { get; } = new BloodLetting();
        public BloodLetting() : base("BloodLetting", 0, CardColor.Red, CardRarity.Uncommon, CardTarget.Self, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseMagicNumber = 3;
            Description = """
                技能
                获得3点能量。
                失去3点生命。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature target)
        {
            user.LoseHealth(3);
            user.Energy += 3;
        }
    }
}
