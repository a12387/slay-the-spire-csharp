using SlayTheSpire.Game.Cards.Red;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SlayTheSpire.Game
{
    enum PlayerFacing
    {
        Left,
        Right
    };
    internal abstract class AbstractPlayer : AbstractCreature
    {
        public CardGroup MasterDeck { get; set; }
        public CardGroup DrawPile { get; set; }
        public CardGroup Hand { get; set; }
        public CardGroup DiscardPile { get; set; }
        public CardGroup ExhaustPile { get; set; }
        public PlayerFacing Facing { get; set; }
        public int Energy { get; set; }
        public const int MaxEnergy = 5;
        public const int MaxHandCards = 10;
        public const int NumDrawCardsEachTurn = 5;

        protected AbstractPlayer(string name, int maxHealth) : base(true, name, maxHealth)
        {
            MasterDeck = new CardGroup(CardGroupType.MasterDeck);
            DrawPile = new CardGroup(CardGroupType.DrawPile);
            Hand = new CardGroup(CardGroupType.Hand);
            DiscardPile = new CardGroup(CardGroupType.DiscardPile);
            ExhaustPile = new CardGroup(CardGroupType.ExhaustPile);
            Facing = PlayerFacing.Right;
            Energy = MaxEnergy;
        }
        public void BeforeBattle()
        {
            DrawPile.Clear();
            Hand.Clear();
            DiscardPile.Clear();
            ExhaustPile.Clear();
            Facing = PlayerFacing.Right;
            Energy = MaxEnergy;
            BuffList.Clear();

            MasterDeck.ForEach(i => DrawPile.Add(i));
            DrawPile.Shuffle();
        }
        public void TurnStart()
        {
            bool loseBlock = true;
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnTurnStart(ref loseBlock,this);
            }
            if(loseBlock)
            {
                CurrentBlock = 0;
            }
            DrawCard(NumDrawCardsEachTurn);
        }
        public void TurnEnd()
        {
            Hand.ForEach(card =>
            {
                if (card.IsEthereal)
                {
                    ExhaustCard(card);
                }
                else if(!card.IsRetain)
                {
                    DiscardPile.Add(card);
                }
            });
        }
        public void DrawCard(int count)
        {
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnDrawCard(ref count);
            }
            if(count == 0)
            {
                return;
            }

            if (!DrawPile.Any())
            {
                DiscardPile.ForEach(i => DrawPile.Add(i));
                DiscardPile.Clear();
                DrawPile.Shuffle();
            }
            for (int i = 0; i < count && Hand.Count <= MaxHandCards && DrawPile.Any(); i++)
            {
                var card = DrawPile.First();

                Hand.Add(card);
                card.OnDrawn(this);
                DrawPile.RemoveAt(0);
            }
        }
        public void ExhaustCard(AbstractCard card)
        {
            DrawPile.Remove(card);
            Hand.Remove(card);
            DiscardPile.Remove(card);
            ExhaustPile.Insert(0, card);
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnExhaustCard(this);
            }
            card.OnExhaust();
        }
        public void UseCard(AbstractCard card, AbstractCreature target)
        {
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnUseCard(this);
            }
        }
        public void LoseEnergy(int cost)
        {
            if (Energy >= cost)
            {
                Energy -= cost;
            }
        }
        public bool CanSelectCard(AbstractCard card)
        {
            if(card.Cost == -1 || Energy >= card.Cost)
            {
                return true;
            }
            else return false;
        }
        public void UseCard(AbstractCard card, Battle battle, AbstractMonster? target)
        {
            BeforeUseCard(battle);
            card.OnUse(this, target);
            AfterUseCard(card);
        }
        public void UseCard(AbstractCard card, Battle battle, List<AbstractMonster> targets)
        {
            BeforeUseCard(battle);
            card.OnUse(this, targets);
            AfterUseCard(card);
        }
        private void BeforeUseCard(Battle battle)
        {
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnUseCard(this);
            }
            for (int i = 0; i < battle.Monsters.Count; i++)
            {
                var buffList = battle.Monsters[i].BuffList;
                for (int j = 0; j < buffList.Count; j++)
                {
                    buffList[j].OnUseCard(this);
                }
            }
        }
        private void AfterUseCard(AbstractCard card)
        {
            Hand.Remove(card);
            if (card.IsExhaust)
            {
                ExhaustCard(card);
            }
            else
            {
                DiscardPile.Add(card);
            }
            
            if(card.Cost == -1)
            {
                Energy = 0;
            }
            else
            {
                Energy -= card.Cost;
            }
        }
    }
}
