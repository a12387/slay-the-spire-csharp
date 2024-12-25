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
            //SetStyle(ControlStyles.Opaque, true);  // 透明
            panelMap.Parent = myPictureBoxMap;
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    using (Brush semiTransparentBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0)))  // 半透明黑色
        //    {
        //        e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);  // 用半透明颜色填充背景
        //    }
        //    base.OnPaint(e);
        //}
    }
}
