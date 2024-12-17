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
        private int LastMove { get; set; }

        protected AbstractMonster(string name, int maxHealth) : base(false, name, maxHealth)
        {

        }
        public abstract void act(AbstractPlayer player);
        public abstract void GenerateNewIntent();
        public virtual void BeforeBattle()
        {
            GenerateNewIntent();
        }
    }
}
