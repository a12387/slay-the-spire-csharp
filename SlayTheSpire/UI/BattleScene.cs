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
            var playerui = new CreatureUI(Battle.Player);
            switch (battle.CurrentFloor)
            {
                case 1:
                    var shieldui = new CreatureUI(Battle.Monsters[0]);
                    var spearui = new CreatureUI(Battle.Monsters[1]);
                    panelPlayerMiddle.Controls.Add(playerui);
                    panelMonsterLeft.Controls.Add(shieldui);
                    panelMonsterRight.Controls.Add(spearui);
                    break;
                case 2:
                    var heartui = new CreatureUI(Battle.Monsters[0]);
                    panelPlayerLeft.Controls.Add(playerui);
                    panelMonsterRight.Controls.Add((heartui));
                    break;
                default:
                    break;
            }

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
