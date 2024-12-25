using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    enum MonsterIntent
    {
        Attack,
        AttackBuff,
        AttackDebuff,
        AttackDefend,
        Buff,
        Debuff,
        StrongDebuff,
        Defend,
        DefendBuff,
        DefendDebuff,
        Magic,
        Unknown,
    };
    internal abstract class AbstractMonster : AbstractCreature
    {
        public MonsterIntent CurrentIntent { get; protected set; }
        public int DamageAmount { get; protected set; }
        public int DamageTimes { get; protected set; }
        //protected MonsterIntent LastMove { get; set; }

        protected AbstractMonster(string name, int maxHealth) : base(false, name, maxHealth)
        {

        }
        public abstract void Act(AbstractPlayer player);
        public abstract void GenerateNewIntent(int round);
        //protected abstract void SetIntent(MonsterIntent intent);
        public virtual void BeforeBattle()
        {
            GenerateNewIntent(0);
            // Add buff or others
        }
        
    }
}
