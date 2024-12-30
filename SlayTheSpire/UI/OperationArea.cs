using SlayTheSpire.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheSpire.UI
{
    internal partial class OperationArea : UserControl
    {
        const int Interval = 10;
        private float ScaleX;

        public event EventHandler DrawPileClick 
        { 
            add
            {
                pictureBoxDrawPile.Click += value;
            } 
            remove
            {
                pictureBoxDrawPile.Click -= value;
            }
        }
        public event EventHandler DiscardPileClick
        {
            add
            {
                pictureBoxDiscardPile.Click += value;
            }
            remove
            {
                pictureBoxDiscardPile.Click -= value;
            }
        }
        public event EventHandler ExhaustPileClick
        {
            add
            {
                labelExhaust.Click += value;
            }
            remove
            {
                labelExhaust.Click -= value;
            }
        }


        public OperationArea()
        {
            InitializeComponent();
            labelEnergy.BackgroundImage = Properties.Resources.energyRed;
            labelEnergy.BackgroundImageLayout = ImageLayout.Stretch;
            labelExhaust.BackgroundImage = Properties.Resources.exhaust;
            labelExhaust.BackgroundImageLayout = ImageLayout.Stretch;
            ScaleX = Width / 1280f;
        }
        public void AddCard(CardButton btn)
        {
            panelHand.Controls.Add(btn);
            btn.Click += onCardSelected;
            btn.Location = new Point((panelHand.Controls.Count - 1) * (btn.Width + Interval), 0);
        }
        public void ShowHandCards(CardGroup hand)
        {
            hand.ForEach(card =>
            {
                AddCard(new CardButton(card));
            });
        }
        public void Clear()
        {
            panelHand.Controls.Clear();
        }
        private void onCardSelected(object? sender, EventArgs e)
        {
            CardButton? btn = sender as CardButton;
            if (btn != null)
            {
                OnCardSelected?.Invoke(btn);
            }
        }
        public void SetEnergyText(int energy)
        {
            labelEnergy.Text = energy.ToString() + "/4";
        }

        private void buttonEndTurn_Click(object sender, EventArgs e)
        {
            OnEndTurn?.Invoke();
        }

        public void OnTurnEnd()
        {
            buttonEndTurn.Enabled = false;
        }

        public void OnTurnStart(CardGroup hand)
        {
            OnHandChanged(hand);
            buttonEndTurn.Enabled = true;
        }

        public void OnHandChanged(CardGroup hand)
        {
            Clear();
            ShowHandCards(hand);
        }

        

        public event Action<CardButton> OnCardSelected;
        public event Action OnEndTurn;
    }
}
