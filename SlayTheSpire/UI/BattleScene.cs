using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlayTheSpire.Game;
using SlayTheSpire.Game.Cards;

namespace SlayTheSpire.UI
{
    internal partial class BattleScene : UserControl
    {
        public BattleScene(Battle battle)
        {
            InitializeComponent();
            Battle = battle;
            var playerui = new PlayerUI();
            panelPlayer.Controls.Add(playerui);

            List<AbstractCard> cards = CardLibrary.GetRandomCards(1);
            operationArea.AddCard(new CardButton(cards[0]));
            operationArea.AddCard(new CardButton(cards[0]));
            operationArea.AddCard(new CardButton(cards[0]));
            operationArea.AddCard(new CardButton(cards[0]));
            operationArea.AddCard(new CardButton(cards[0]));
            operationArea.AddCard(new CardButton(cards[0]));
            operationArea.AddCard(new CardButton(cards[0]));

        }

        private Battle Battle;
    }
}
