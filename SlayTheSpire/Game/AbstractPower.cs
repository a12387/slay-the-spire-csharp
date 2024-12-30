using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    enum PowerType
    {
        Buff,
        Debuff
    }
    internal abstract class AbstractPower
    {
        public string Name { get; }
        public int Amount { get; set; }
        public PowerType Type { get; }

        protected AbstractPower(string name, int amount, PowerType type)
        {
            Name = name;
            Amount = amount;    
            Type = type;
        }
        public virtual void OnAttack(ref int amount, int order) { }
        public virtual void OnAddBlock(ref int amount, int order) { }
        public virtual void OnHurt(ref int amount) { }
        public virtual void OnLoseHealth(ref int amount) { }
        //public virtual void OnDrawCard(AbstractCard card) { }
        public virtual void OnDrawCard(ref int amount) { }
        public virtual void OnExhaustCard(AbstractPlayer player) { }
        public virtual void OnTurnStart(ref bool loseblock, AbstractPlayer player) { }
        public virtual void OnAppliedDebuff(ref int amount) { }
        public virtual void OnUseCard(AbstractPlayer player) { }
        public virtual void OnLimitBreak() { }
    }
}
