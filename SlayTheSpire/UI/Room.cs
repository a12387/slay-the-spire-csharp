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

namespace SlayTheSpire.UI
{
    public partial class Room : UserControl
    {

        private readonly Player player;
        private readonly GameMap map;
        bool mapExists = false;

        internal Room(Player player) : base()
        {
            InitializeComponent();
            this.player = player;
            this.player.CurrentHealthChanged += this.playerInfo.SetCurrentHealth;
            this.player.MaxHealthChanged += this.playerInfo.SetMaxHealth;
            this.playerInfo.MapIconClicked += this.MapIcon_Click;
            this.map = new GameMap();
            this.map.RoomChanged += ChangeRoom;
        }
        public void AddPage(Control control, Control parent)
        {
            MainPanel.Controls.Add(control);
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
            MainPanel.Controls.Remove(control);
        }
        public void ShowMap()
        {
            this.AddPage(map, MainPanel);
            playerInfo.BringToFront();
            mapExists = true;
        }
        public void ShowMapD(Object? sender, EventArgs e)
        {
            ShowMap();
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
                    var room = new BattleScene();
                    CloseMap();
                    ChangePage(room);
                    break;

            }
        }
    }
}
