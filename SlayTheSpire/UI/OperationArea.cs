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
    // OperationArea 是用于显示玩家操作区域的ui
    // 包括手牌，抽牌堆，弃牌堆，消耗牌堆，能量等，还有一个结束回合的按钮
    // 通过事件 OnCardSelected，OnEndTurn 来通知外部发生了相应的操作
    // 通过事件 DrawPileClick，DiscardPileClick，ExhaustPileClick 来通知外部点击了相应的牌堆
    // 通过事件 OnHandChanged 来通知外部手牌发生了变化
    // 通过方法 SetEnergyText 来设置能量显示（这里其实应该同时传入maxEnergy，不过我们默认只有4费了）
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

        

        public event Action<CardButton>? OnCardSelected;
        public event Action? OnEndTurn;
    }
}
