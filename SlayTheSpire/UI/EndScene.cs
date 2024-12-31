using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheSpire.UI
{
    public partial class EndScene : UserControl
    {
        public EndScene(bool victory)
        {
            InitializeComponent();
            if (victory)
            {
                pictureBox1.Image = Properties.Resources.ironclad;
                labelMessage.Text = "YOU WIN!";
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Program.MainForm.ChangePage(new MainMenu());
        }
    }
}
