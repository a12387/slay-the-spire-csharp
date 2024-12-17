using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    enum CardColor
    {
        Red,
        Colorless,
        // Curse
    };
    enum CardRarity
    {
        Basic,
        Special,
        Common,
        Uncommon,
        Rare
        // Curse
    };
    enum CardTarget
    {
        Enemy,
        AllEnemies,
        Self,
        None
    };
    enum CardType
    {
        Attack,
        Skill,
        Power,
        Status
        // Curse
    };
    internal abstract class AbstractCard
    {
        public string Name { get; }
        public int Cost { get; }
        public CardColor Color { get; }
        public CardRarity Rarity { get; }
        public CardTarget Target { get; }
        public CardType Type { get; }

        public abstract string Description { get; protected set; }
        // public abstract bool IsUpgrade;
        public abstract bool IsRetain { get; }
        public abstract bool IsInnate { get; }
        public abstract bool IsExhaust { get; }
        public abstract bool IsEthereal { get; }

        public abstract int BaseDamage { get; }
        public abstract int BaseBlock { get; }
        public abstract int BaseMagicNumber { get; }
        public abstract int BaseDraw { get; }
        public abstract int BaseDiscard { get; }


        protected AbstractCard(string name, int cost, CardColor color, CardRarity rarity, CardTarget target, CardType type)
        {
            Name = name;
            Cost = cost;
            Color = color;
            Rarity = rarity;
            Target = target;
            Type = type;
        }
        // public abstract void Upgrade();

        public abstract void OnUse(AbstractPlayer user, AbstractCreature target);

        public virtual void OnDrawn() { }
        public virtual void OnExhaust() { }
    }
}
