using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlayTheSpire.Game;

namespace SlayTheSpire.UI
{
    internal partial class PileView: UserControl
    {
        public event EventHandler OKClick
        {
            add
            {
                buttonOK.Click += value;
            }
            remove
            {
                buttonOK.Click -= value;
            }
        }
        List<CardButton> CardButtons;
        public PileView(CardGroup cards)
        {
            InitializeComponent();
            myPictureBoxBackground.Parent = panel1;
            myPictureBoxBackground.Height = 1280;
            CardButtons = new List<CardButton>();
            float scaleX = Width / 1280f;
            float scaleY = Height / 720f;
            for (int i = 0; i < cards.Count; i++)
            {
                var cardButton = new CardButton(cards[i]);
                CardButtons.Add(cardButton);
                cardButton.Parent = myPictureBoxBackground;
                cardButton.Location = new Point((int)(scaleX * ((i % 6) * (180 + 200 / 7f) + 200 / 7f)), (int)(scaleY * ((i / 6) * (252 + 30) + 30)) + 40);
            }
        }

        public PileView(CardGroup cards, int num, List<AbstractCard> chosen, AbstractCard currentCard) : this(cards)
        {
            for (int i = 0; i < CardButtons.Count; i++)
            {
                var cardButton = CardButtons[i];
                cardButton.Click += (sender, args) =>
                {
                    if(chosen.Contains(cardButton.Card))
                    {
                        chosen.Remove(cardButton.Card);
                    }
                    else if(chosen.Count < num)
                    {
                        chosen.Add(cardButton.Card);
                    }
                };
            }
            buttonOK.Click += (sender, args) =>
            {
                if(chosen.Count == num)
                {
                    for(int i = 0; i < chosen.Count; i++)
                    {
                        currentCard.Effect(Dungeon.Player, chosen[i]);
                    }
                    Dispose();
                }
            };
        }


        
    }
}
