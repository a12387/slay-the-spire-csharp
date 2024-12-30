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
        CardButton? selectedCard;

        public BattleScene(Battle battle)
        {
            InitializeComponent();
            Battle = battle;
            var playerui = new CreatureUI(Battle.Player);
            List<CreatureUI> Mobs = new List<CreatureUI>();

            switch (battle.CurrentFloor)
            {
                case 1:
                    var shieldui = new CreatureUI(Battle.Monsters[0]);
                    var spearui = new CreatureUI(Battle.Monsters[1]);
                    Mobs.Add(shieldui);
                    Mobs.Add(spearui);

                    panelMiddle.Controls.Add(playerui);
                    panelLeft.Controls.Add(shieldui);
                    panelRight.Controls.Add(spearui);
                    break;
                case 2:
                    var heartui = new CreatureUI(Battle.Monsters[0]);
                    Mobs.Add(heartui);
                    panelLeft.Controls.Add(playerui);
                    panelRight.Controls.Add((heartui));
                    break;
                default:
                    break;
            }
            operationArea.OnCardSelected += (CardButton btn) =>
            {
                if (battle.Player.CanSelectCard(btn.Card))
                {
                    switch (btn.Card.Target)
                    {
                        case CardTarget.None:
                            break;
                        case CardTarget.Self:
                            if (battle.Player.CanSelectCard(btn.Card))
                            {
                                battle.Player.UseCard(btn.Card, battle, battle.Player);
                            }
                            break;
                        case CardTarget.AllEnemies:
                            if (battle.Player.CanSelectCard(btn.Card))
                            {
                                battle.Player.UseCard(btn.Card, battle, battle.Monsters);
                            }
                            break;
                        case CardTarget.Enemy:
                            if (battle.Player.CanSelectCard(btn.Card))
                            {
                                selectedCard = btn;
                            }
                            break;
                    }
                }
            };
            foreach (var mob in Mobs)
            {
                mob.CreatruePictureBox.Click += (object? sender, EventArgs e) =>
                {
                    var monster = mob as CreatureUI;
                    var card = selectedCard?.Card;
                    if (monster != null && card != null && battle.Player.CanSelectCard(card))
                    {
                        battle.Player.UseCard(card, battle, monster.Creature);
                    }
                };
            }
            operationArea.OnEndTurn += () =>
            {
                battle.Player.TurnEnd();
                battle.MonstersTurnStart();
            };
            battle.Player.TurnStarted += operationArea.OnTurnStart;
            battle.Player.TurnEnded += operationArea.OnTurnEnd;
            battle.Player.TurnEnded += () => { selectedCard = null; };
            battle.Player.HandChanged += operationArea.OnHandChanged;
            battle.Enter();
        }

        private Battle Battle;

        private void panelMonsterLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
