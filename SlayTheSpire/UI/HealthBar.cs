﻿using System;
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
        private int block;
        public int Block
        {
            get { return block; }
            set
            {
                if (block != value)
                {
                    block = value;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Brush semiTransparentBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0)))  // 半透明黑色
            {
                e.Graphics.FillRectangle(semiTransparentBrush, this.ClientRectangle);  // 用半透明颜色填充背景
            }
            using (Brush redBrush = new SolidBrush(Color.Red))
            {
                Rectangle r = this.ClientRectangle;
                r.Width = this.ClientRectangle.Width * currentHealth / maxHealth;
                e.Graphics.FillRectangle(redBrush, r);
            }
            base.OnPaint(e);
        }
    }
}
