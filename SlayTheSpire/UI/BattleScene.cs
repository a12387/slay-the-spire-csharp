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
    // BattleScene 是战斗场景的UI类，其中有三个Panel用于放置玩家和敌人的UI，一个OperationArea用于放置玩家的手牌和操作区域
    // 通过Battle类来控制战斗的进行，通过为Battle类的事件绑定UI的事件来实现UI的更新
    // 通过Map类显示地图，通过EndScene类显示胜利或失败的场景
    // 通过PileView类来显示玩家的牌堆
    // 通过CreatureUI类来显示玩家和敌人的生命值和状态
    internal partial class BattleScene : UserControl
    {
        CardButton? selectedCard;

        public BattleScene(Battle battle)
        {
            InitializeComponent();
            operationArea.DrawPileClick += ShowDrawPile;
            operationArea.DiscardPileClick += ShowDiscardPile;
            operationArea.ExhaustPileClick += ShowExhaustPile;

            Battle = battle;
            var playerui = new CreatureUI(Battle.Player);
            List<CreatureUI> Mobs = new List<CreatureUI>();

            Battle.Player.EnergyChanged += operationArea.SetEnergyText;
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
                            if (battle.Player.CanSelectCard(btn.Card))
                            {
                                battle.Player.UseCard(btn.Card, battle, battle.Player);
                                selectedCard = null;
                            }
                            break;
                        case CardTarget.Self:
                            if (battle.Player.CanSelectCard(btn.Card))
                            {
                                battle.Player.UseCard(btn.Card, battle, battle.Player);
                                selectedCard = null;
                            }
                            break;
                        case CardTarget.AllEnemies:
                            if (battle.Player.CanSelectCard(btn.Card))
                            {
                                battle.Player.UseCard(btn.Card, battle, battle.Monsters);
                                selectedCard = null;
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
                    if (monster != null && card != null)
                    {
                        battle.Player.UseCard(card, battle, monster.Creature);
                    }
                    selectedCard = null;
                };
                mob.Creature.Die += () =>
                {
                    mob.Dispose();
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

        private PileView? Pile;
        public void ShowDrawPile(object? sender, EventArgs e)
        {
            Pile = new PileView(Battle.Player.DrawPile);
            Pile.OKClick += ClosePile;
            Room.Instance.AddPage(Pile, this);
        }
        public void ShowDiscardPile(object? sender, EventArgs e)
        {
            Pile = new PileView(Battle.Player.DiscardPile);
            Pile.OKClick += ClosePile;
            Room.Instance.AddPage(Pile, this);
        }
        public void ShowExhaustPile(object? sender, EventArgs e)
        {
            Pile = new PileView(Battle.Player.ExhaustPile);
            Pile.OKClick += ClosePile;
            Room.Instance.AddPage(Pile, this);
        }

        public void ClosePile(object? sender, EventArgs e)
        {
            Controls.Remove(Pile);
            Pile?.Dispose();
        }

        public void BattleFinish()
        {
            buttonContinue.Visible = true;
            operationArea.Dispose();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(Battle.CurrentFloor != 2)
            {
                Room.Instance.ShowMap();
            }
            else
            {
                var victoryScene = new EndScene(true);
                Room.Instance.ChangePage(victoryScene);
            }
        }
    }
}
