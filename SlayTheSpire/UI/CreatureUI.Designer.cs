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
            pictureBoxWithLabel1 = new PictureBoxWithLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreature).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCreature
            // 
            pictureBoxCreature.Location = new Point(21, 3);
            pictureBoxCreature.Margin = new Padding(0);
            pictureBoxCreature.Name = "pictureBoxCreature";
            pictureBoxCreature.Size = new Size(250, 213);
            pictureBoxCreature.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCreature.TabIndex = 0;
            pictureBoxCreature.TabStop = false;
            // 
            // healthBar
            // 
            healthBar.BackColor = Color.Transparent;
            healthBar.CurrentBlock = 23;
            healthBar.CurrentHealth = 40;
            healthBar.Location = new Point(58, 216);
            healthBar.Margin = new Padding(0);
            healthBar.MaxHealth = 80;
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(213, 29);
            healthBar.TabIndex = 1;
            // 
            // statusBar
            // 
            statusBar.BackColor = Color.Transparent;
            statusBar.Location = new Point(21, 245);
            statusBar.Margin = new Padding(0);
            statusBar.Name = "statusBar";
            statusBar.Size = new Size(250, 24);
            statusBar.TabIndex = 2;
            // 
            // pictureBoxWithLabel1
            // 
            pictureBoxWithLabel1.BackColor = Color.Transparent;
            pictureBoxWithLabel1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pictureBoxWithLabel1.Image = Properties.Resources.block;
            pictureBoxWithLabel1.labelText = "0";
            pictureBoxWithLabel1.Location = new Point(21, 216);
            pictureBoxWithLabel1.Margin = new Padding(0);
            pictureBoxWithLabel1.Name = "pictureBoxWithLabel1";
            pictureBoxWithLabel1.Size = new Size(37, 29);
            pictureBoxWithLabel1.TabIndex = 3;
            pictureBoxWithLabel1.Visible = false;
            // 
            // CreatureUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pictureBoxWithLabel1);
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
        private PictureBoxWithLabel pictureBoxWithLabel1;
    }
}
