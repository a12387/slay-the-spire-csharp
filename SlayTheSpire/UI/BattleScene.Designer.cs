﻿namespace SlayTheSpire.UI
{
    partial class BattleScene
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            panelPlayer = new Panel();
            SuspendLayout();
            // 
            // panelPlayer
            // 
            panelPlayer.BackColor = Color.Transparent;
            panelPlayer.Location = new Point(490, 150);
            panelPlayer.Name = "panelPlayer";
            panelPlayer.Size = new Size(300, 400);
            panelPlayer.TabIndex = 0;
            // 
            // BattleScene
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scene;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panelPlayer);
            Name = "BattleScene";
            Size = new Size(1280, 720);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPlayer;
    }
}
