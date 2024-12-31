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
    // GameMap 是用于显示地图的UI类
    // 为了实现对后方界面的透明效果，我们使用了重写的myPictureBox
    // 需要注意的是控件的叠加顺序： UI -> panel -> myPictureBox -> pictureBox
    // 在显示BuffUI、IntentUI的时候也借鉴了这里的解决方式
    public partial class GameMap : UserControl
    {
        public GameMap()
        {
            InitializeComponent();
            //SetStyle(ControlStyles.Opaque, true);  // 透明
            panelMap.Parent = myPictureBoxMap;
        }

        public event EventHandler<int>? RoomChanged;

        private void pictureBoxElite_Click(object? sender, EventArgs e)
        {
            RoomChanged?.Invoke(this, 1);
            pictureBoxElite.Click -= pictureBoxElite_Click;
        }

        private void pictureBoxHeart_Click(object? sender, EventArgs e)
        {
            RoomChanged?.Invoke(this, 2);
            pictureBoxHeart.Click -= pictureBoxHeart_Click;
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
