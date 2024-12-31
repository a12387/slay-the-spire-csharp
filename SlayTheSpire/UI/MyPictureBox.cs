using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SlayTheSpire.UI
{
    internal class MyPictureBox : PictureBox
    {
        public MyPictureBox() : base()
        {
            SetStyle(ControlStyles.Opaque, true);  // 透明
            DoubleBuffered = false;
            BackGroundA = 200;
        }

        public int BackGroundA { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush semiTransparentBrush = new SolidBrush(Color.FromArgb(BackGroundA, 0, 0, 0)))  // 半透明黑色
            {
                e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);  // 用半透明颜色填充背景
            }
            base.OnPaint(e);
        }
    }
}
