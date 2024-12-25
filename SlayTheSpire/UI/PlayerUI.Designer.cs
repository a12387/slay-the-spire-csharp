namespace SlayTheSpire.UI
{
    partial class PlayerUI
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
            pictureBox1 = new PictureBox();
            healthBar1 = new HealthBar();
            statusBar1 = new StatusBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ironclad;
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // healthBar1
            // 
            healthBar1.Location = new Point(21, 351);
            healthBar1.Name = "healthBar1";
            healthBar1.Size = new Size(250, 50);
            healthBar1.TabIndex = 1;
            // 
            // statusBar1
            // 
            statusBar1.Location = new Point(21, 315);
            statusBar1.Name = "statusBar1";
            statusBar1.Size = new Size(250, 30);
            statusBar1.TabIndex = 2;
            // 
            // PlayerUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(statusBar1);
            Controls.Add(healthBar1);
            Controls.Add(pictureBox1);
            Name = "PlayerUI";
            Size = new Size(300, 400);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private HealthBar healthBar1;
        private StatusBar statusBar1;
    }
}
