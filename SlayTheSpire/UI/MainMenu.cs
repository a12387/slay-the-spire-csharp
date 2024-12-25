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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void GameStart(object sender, MouseEventArgs e)
        {
            GameStartUI();
        }

        private void GameStartUI()
        {
            var player = new Player("IronClad", 80);
            var room = new Room(player);
            var starterRoom = new StarterRoom();
            starterRoom.ShowMap += room.ShowMapD;
            room.ChangePage(starterRoom);
            Program.MainForm.ChangePage(room);
        }

        //private Room room;
    }
}
