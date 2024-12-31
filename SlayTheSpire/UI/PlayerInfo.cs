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
        // PlayerInfo 是用于显示玩家信息的控件（也就是界面上方的栏）
        // 包括当前生命值、最大生命值、地图图标、卡组图标
        public PlayerInfo()
        {
            InitializeComponent();
        }

        public event EventHandler? MapIconClicked;
        public event EventHandler? DeckIconClicked;

        public void SetCurrentHealth(int health)
        {
            healthInfo.CurrentHealth = health;
        }

        public void SetMaxHealth(int health)
        {
            healthInfo.MaxHealth = health;
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            MapIconClicked?.Invoke(this, e);
        }

        private void pictureBoxDeck_Click(object sender, EventArgs e)
        {
            DeckIconClicked?.Invoke(this, e);
        }
    }
}
