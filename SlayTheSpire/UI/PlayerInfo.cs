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
    public partial class PlayerInfo : UserControl
    {
        public PlayerInfo()
        {
            InitializeComponent();
        }

        public event EventHandler MapIconClicked;

        public void SetCurrentHealth(object? sender, int health)
        {
            healthInfo.CurrentHealth = health;
        }

        public void SetMaxHealth(object? sender, int health)
        {
            healthInfo.MaxHealth = health;
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            MapIconClicked?.Invoke(this, e);
        }
    }
}
