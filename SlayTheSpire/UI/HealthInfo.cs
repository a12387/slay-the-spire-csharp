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
    public partial class HealthInfo : UserControl
    {
        public HealthInfo()
        {
            InitializeComponent();
            healthIconSize = pictureBoxHealth.Size;
        }

        private Size healthIconSize;

        private void HealthInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHealth.Size = new System.Drawing.Size((int)(healthIconSize.Width * 1.2), (int)(healthIconSize.Height * 1.2));
        }

        private void HealthInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHealth.Size = healthIconSize;
        }

        private int currentHealth;
        public int CurrentHealth
        {
            get { return currentHealth; }
            set
            {
                if (currentHealth != value) {
                    currentHealth = value;
                    labelHealth.Text = String.Format("{0}/{1}", CurrentHealth, MaxHealth);
                }
            }
        }
        private int maxHealth;
        public int MaxHealth
        {
            get { return maxHealth; }
            set
            {
                if (maxHealth != value)
                {
                    maxHealth = value;
                    labelHealth.Text = String.Format("{0}/{1}", CurrentHealth, MaxHealth);
                }
            }
        }
    }
}
