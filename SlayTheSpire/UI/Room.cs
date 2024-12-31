using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlayTheSpire.Game;
using SlayTheSpire.Game.Monsters;

namespace SlayTheSpire.UI
{
    internal partial class Room : UserControl
    {
        private readonly GameMap map;
        private PileView deck;
        bool mapExists = false;
        bool deckExists = false;
        public static Room Instance;
        internal Room() : base()
        {
            var player = Dungeon.Player;
            InitializeComponent();
            player.CurrentHealthChanged += this.playerInfo.SetCurrentHealth;
            player.MaxHealthChanged += this.playerInfo.SetMaxHealth;
            player.Die += () =>
            {
                var deathScene = new EndScene(false);
                ChangePage(deathScene);
            };
            playerInfo.MapIconClicked += this.MapIcon_Click;
            playerInfo.DeckIconClicked += this.DeckIcon_Click;
            map = new GameMap();
            map.RoomChanged += ChangeRoom;
            
        }
        public void AddPage(Control control, Control parent)
        {
            MainPanel.Controls.Add(control);
            control.Parent = parent;
            control.BringToFront();
        }
        public void AddPage(Control control)
        {
            AddPage(control, this);
        }
        public void ChangePage(Control control)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
        }
        public void DeletePage(Control control)
        {
            MainPanel.Controls.Remove(control);
        }
        public void ShowMap()
        {
            this.AddPage(map, MainPanel);
            playerInfo.BringToFront();
            mapExists = true;
        }
        public void CloseMap()
        {
            if (mapExists)
            {
                DeletePage(map);
                mapExists = false;
            }
        }

        private void MapIcon_Click(object? sender, EventArgs e)
        {
            if (mapExists)
            {
                CloseMap();
            }
            else
            {
                ShowMap();
            }
        }
        public void ShowDeck()
        {
            deck = new PileView(Dungeon.Player.MasterDeck);
            deck.OKClick += (sender, e) =>
            {
                CloseDeck();
            };
            this.AddPage(deck, MainPanel);
            playerInfo.BringToFront();
            deckExists = true;
        }
        public void CloseDeck()
        {
            if (deckExists)
            {
                DeletePage(deck);
                deckExists = false;
            }
        }
        private void DeckIcon_Click(object? sender, EventArgs e)
        {
            if (deckExists)
            {
                CloseDeck();
            }
            else
            {
                ShowDeck();
            }
        }

        public void ChangeRoom(Object? sender, int floor)
        {
            BattleScene room;
            Battle battle;
            switch (floor)
            {
                case 1:
                    battle = new Battle(Dungeon.Player, new List<AbstractMonster>() { new SpireShield(), new SpireSpear()}, 1);
                    break;
                case 2:
                    battle = new Battle(Dungeon.Player, new List<AbstractMonster> { new CorruptHeart()}, 2);
                    break;
                default:
                    throw new Exception();
            }
            room = new BattleScene(battle);
            battle.Victory += room.BattleFinish;
            CloseMap();
            ChangePage(room);
        }

        public void ShowCardGroup(CardGroup group)
        {
            var pileView = new PileView(group);
            AddPage(pileView, MainPanel);
        }
    }
}
