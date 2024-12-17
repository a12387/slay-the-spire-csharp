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
            MasterDeck.Clear();
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
            for (int i = 0; i < BuffList.Count; i++)
            {
                BuffList[i].OnTurnStart();
            }
            DrawCard(NumDrawCardsEachTurn);
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

            if (DrawPile.Any())
            {
                DiscardPile.ForEach(i => DrawPile.Add(i));
                DrawPile.Shuffle();
            }
            for (int i = 0; i < count && Hand.Count <= MaxHandCards && !DrawPile.Any(); i++)
            {
                var card = DrawPile.First();
                Hand.Add(card);

                card.OnDrawn();
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
                BuffList[i].OnExhaustCard();
            }
            card.OnExhaust();
        }
    }
}
