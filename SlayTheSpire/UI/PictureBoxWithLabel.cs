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
    public partial class PictureBoxWithLabel : UserControl
    {
        public PictureBoxWithLabel()
        {
            InitializeComponent();
        }

        private void PictureBoxWithLabel_Load(object sender, EventArgs e)
        {
            label.Parent = pictureBox;
        }

        private string labeltext;
        public String labelText
        {
            get { return labeltext; }
            set
            {
                labeltext = value;
                label.Text = labeltext;
            }
        }
        private Image image;
        public Image Image
        {
            get { return image; }
            set
            {
                image = value;
                pictureBox.Image = image;
            }
        }
    }
}
