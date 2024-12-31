using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlayTheSpire.Game.Powers;

namespace SlayTheSpire.Game.Cards.Red
{
    internal class SpotWeakness : AbstractCard
    {
        static public SpotWeakness Instance { get; } = new SpotWeakness();
        public SpotWeakness() : base("观察弱点", "SpotWeakness", 1, CardColor.Red, CardRarity.Uncommon, CardTarget.Enemy, CardType.Skill)
        {
            IsRetain = false;
            IsInnate = false;
            IsExhaust = false;
            IsEthereal = false;
            BaseMagicNumber = 4;
            Description = """
                技能
                如果一名敌人的意图是攻击，你获得4点力量。
                """;
        }
        public override void OnUse(AbstractPlayer user, AbstractCreature? target)
        {
            if (target != null)
            {
                AbstractMonster? monster = target as AbstractMonster;
                if (monster != null)
                {
                    if(monster.CurrentIntent==MonsterIntent.Attack||monster.CurrentIntent==MonsterIntent.AttackBuff
                        || monster.CurrentIntent == MonsterIntent.AttackDebuff || monster.CurrentIntent == MonsterIntent.AttackDefend)
                    {
                        user.ApplyPower(new Strength(BaseMagicNumber));
                    }
                }
            }
        }
    }
}
