﻿using System;
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
                    panelMiddle.Controls.Add(playerui);
                    panelLeft.Controls.Add(shieldui);
                    panelRight.Controls.Add(spearui);
                    break;
                case 2:
                    var heartui = new CreatureUI(Battle.Monsters[0]);
                    panelLeft.Controls.Add(playerui);
                    panelRight.Controls.Add((heartui));
                    break;
                default:
                    break;
            }
            var task = Task.Run(battle.Enter);
            task.ContinueWith(t =>
            {
                operationArea.ShowHandCards(battle.Player.Hand);
            });
        }

        private Battle Battle;

        private void panelMonsterLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
