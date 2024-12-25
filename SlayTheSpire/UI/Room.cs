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
using SlayTheSpire.Game.Monsters;

namespace SlayTheSpire.UI
{
    public partial class Room : UserControl
    {
        private readonly GameMap map;
        bool mapExists = false;

        internal Room() : base()
        {
            var player = Dungeon.Player;
            InitializeComponent();
            player.CurrentHealthChanged += this.playerInfo.SetCurrentHealth;
            player.MaxHealthChanged += this.playerInfo.SetMaxHealth;
            playerInfo.MapIconClicked += this.MapIcon_Click;
            map = new GameMap();
            map.RoomChanged += ChangeRoom;
        }
        public void AddPage(Control control, Control parent)
        {
            if(!control.Visible)
            {
                control.Show();
            }
            control.Parent = parent;
            control.BringToFront();
        }
        public void ChangePage(Control control)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(control);
        }
        public void DeletePage(Control control)
        {
            control.Dispose();
            Program.MainForm.Invalidate();
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

        public void ChangeRoom(Object? sender, int floor)
        {
            switch (floor)
            {
                case 1:
                    var room = new BattleScene(new Battle(Dungeon.Player, new List<AbstractMonster>() { new SpireShield(), new SpireSpear()}, 1));
                    CloseMap();
                    ChangePage(room);
                    break;

            }
        }
    }
}
