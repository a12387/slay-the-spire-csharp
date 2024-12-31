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
        public event Action<MonsterIntent, int, int>? MonsterIntentChanged;
        private MonsterIntent currentIntent;
        public MonsterIntent CurrentIntent 
        { 
            get {  return currentIntent; }
            protected set
            {
                currentIntent = value;
                MonsterIntentChanged?.Invoke(currentIntent, DamageAmount, DamageTimes);
            }
        }

        public int DamageAmount { get; protected set; }
        public int DamageTimes { get; protected set; }
        //protected MonsterIntent LastMove { get; set; }

        protected AbstractMonster(string name, int maxHealth) : base(false, name, maxHealth)
        {

        }
        public abstract void Act(AbstractPlayer player, List<AbstractMonster> monsters, int round);
        public abstract void GenerateNewIntent(int round);
        //protected abstract void SetIntent(MonsterIntent intent);
        public override void BeforeBattle()
        {
            base.BeforeBattle();
            MonsterIntentChanged?.Invoke(CurrentIntent, DamageAmount, DamageTimes);
        }
        public void TurnStart()
        {
            CurrentBlock = 0;
            for(int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnTurnStart();
            }
        }
    }
}
