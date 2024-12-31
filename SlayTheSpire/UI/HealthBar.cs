using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlayTheSpire.UI
{
    // HealthBar 是用于显示生命值的UI类
    // 当没有格挡时，生命值条为红色，有格挡时为蓝色
    // 有格挡时，血条左侧添加一个显示数字的小盾图标
    // 用重写Onpaint的方法来实现非满血情况下的显示
    public partial class HealthBar : UserControl
    {
        public HealthBar()
        {
            InitializeComponent();
            //progressBar.Parent = labelHealth;
        }
        private int currentHealth;
        public int CurrentHealth
        {
            get { return currentHealth; }
            set
            {
                if (currentHealth != value)
                {
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
        private int currentBlock;
        public int CurrentBlock
        {
            get { return currentBlock; }
            set
            {
                if (currentBlock != value)
                {
                    currentBlock = value;
                    Refresh();
                }
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush;
            if (CurrentBlock > 0)
            {
                brush = new SolidBrush(Color.Blue);
            }
            else
            {
                brush = new SolidBrush(Color.Red);
            }
            Rectangle r = this.ClientRectangle;
            r.Width = this.ClientRectangle.Width * currentHealth / maxHealth;
            e.Graphics.FillRectangle(brush, r);
            base.OnPaint(e);
        }
    }
}
