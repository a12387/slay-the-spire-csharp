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
        public int Cost { set; get; }
        public CardColor Color { get; }
        public CardRarity Rarity { get; }
        public CardTarget Target { get; }
        public CardType Type { get; }

        public string Description { get; protected set; }
        // public abstract bool IsUpgrade;
        public bool IsRetain { get; protected set; }
        public bool IsInnate { get; protected set; }
        public bool IsExhaust { get; set; }
        public bool IsEthereal { get; protected set; }

        public int BaseDamage { get; protected set; }
        public int BaseBlock { get; protected set; }
        public int BaseMagicNumber { get; protected set; }
        public int BaseDraw { get; protected set; }
        public int BaseDiscard { get; protected set; }


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

        public virtual void OnUse(AbstractPlayer user, AbstractCreature target) { }
        public virtual void OnUse(AbstractPlayer user, List<AbstractMonster> targets) { }

        public virtual void OnDrawn() { }
        public virtual void OnExhaust() { }
        //public virtual void MakeCopy() { }
    }
}
