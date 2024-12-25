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
    internal partial class OperationArea : UserControl
    {
        const int Interval = 10;
        private float ScaleX;
        public OperationArea()
        {
            InitializeComponent();
            labelEnergy.BackgroundImage = Properties.Resources.energyRed;
            labelEnergy.BackgroundImageLayout = ImageLayout.Stretch;
            labelExhaust.BackgroundImage = Properties.Resources.exhaust;
            labelExhaust.BackgroundImageLayout = ImageLayout.Stretch;
            ScaleX = Width / 1280f;
        }
        public void AddCard(CardButton btn)
        {
            panelHand.Controls.Add(btn);
            btn.Location = new Point((panelHand.Controls.Count - 1) * (btn.Width + Interval), 0);
        }
    }
}
