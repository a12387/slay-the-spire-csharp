using SlayTheSpire.Game;
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
    // BuffBar 是用于显示玩家或敌人的Buff条的UI类
    // 通过PaintBuffs方法来显示Buff
    public partial class BuffBar : UserControl
    {
        public BuffBar()
        {
            InitializeComponent();
        }
        internal void PaintBuffs(List<AbstractPower> abstractPowers)
        {
            Controls.Clear();
            int currentX = 0;
            foreach (AbstractPower power in abstractPowers)
            {
                var buffui = new BuffUI();
                buffui.PaintBuff(power);
                buffui.Parent = this;
                buffui.Location = new Point(currentX, 0);
                currentX += buffui.Width;
            }
        }
    }
}
