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
    public partial class BattleScene : UserControl
    {
        public BattleScene()
        {
            InitializeComponent();
        }

        private Battle battle;
    }
}
