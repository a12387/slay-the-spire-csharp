using SlayTheSpire.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheSpire
{
    public partial class StarterRoom : UserControl
    {
        public StarterRoom()
        {
            InitializeComponent();
        }

        private void StartJourney(object sender, EventArgs e)
        {
            ShowMap();
        }
        private void ShowMap()
        {
            var map = new GameMap();
            Program.MainForm.AddPage(map, this);
        }
    }
}
