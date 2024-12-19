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
    public partial class GameMap : UserControl 
    { 
        public GameMap()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush semiTransparentBrush = new SolidBrush(Color.FromArgb(128, 255, 0, 0)))  // 半透明红色
            {
                e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);  // 用半透明颜色填充背景
            }
            base.OnPaint(e);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT
                return cp;
            }
        }
    }
}
