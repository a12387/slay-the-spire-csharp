namespace SlayTheSpire.UI
{
    partial class CreatureUI
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
            pictureBoxCreature = new PictureBox();
            healthBar = new HealthBar();
            statusBar = new StatusBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreature).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCreature
            // 
            pictureBoxCreature.Location = new Point(21, 3);
            pictureBoxCreature.Name = "pictureBoxCreature";
            pictureBoxCreature.Size = new Size(250, 213);
            pictureBoxCreature.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCreature.TabIndex = 0;
            pictureBoxCreature.TabStop = false;
            // 
            // healthBar
            // 
            healthBar.BackColor = Color.Transparent;
            healthBar.CurrentHealth = 0;
            healthBar.Location = new Point(21, 210);
            healthBar.MaxHealth = 0;
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(250, 29);
            healthBar.TabIndex = 1;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.Location = new Point(21, 245);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(250, 24);
            statusBar.TabIndex = 2;
            // 
            // CreatureUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(statusBar);
            Controls.Add(healthBar);
            Controls.Add(pictureBoxCreature);
            Name = "CreatureUI";
            Size = new Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCreature;
        private HealthBar healthBar;
        private StatusBar statusBar;
    }
}
