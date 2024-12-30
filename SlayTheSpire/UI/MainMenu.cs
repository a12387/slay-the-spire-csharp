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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void GameStart(object sender, MouseEventArgs e)
        {
            GameStartMain();
            GameStartUI();
        }

        private void GameStartUI()
        {
            Room.Instance = new Room();
            var room = Room.Instance;
            var starterRoom = new StarterRoom();
            starterRoom.ShowMap += room.ShowMap;
            room.ChangePage(starterRoom);
            Program.MainForm.ChangePage(room);
        }
        private void GameStartMain() 
        {
            Dungeon.Init();
        }

        //private Room room;
    }
}
