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
            GameStartUI();
        }
        private void GameStartUI()
        {
            var starterRoom = new StarterRoom();
            Program.MainForm.ChangePage(starterRoom);
        }
        
    }
}
