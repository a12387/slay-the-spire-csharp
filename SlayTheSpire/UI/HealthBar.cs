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
    public partial class HealthBar : UserControl
    {
        public HealthBar()
        {
            InitializeComponent();
            labelHealth.Parent = progressBar;
        }
    }
}
