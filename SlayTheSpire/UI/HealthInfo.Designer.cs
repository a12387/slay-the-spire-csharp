namespace SlayTheSpire.UI
{
    partial class HealthInfo
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
            pictureBoxHealth = new PictureBox();
            labelHealth = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHealth).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHealth
            // 
            pictureBoxHealth.Image = Properties.Resources.panelHeart;
            pictureBoxHealth.Location = new Point(0, 0);
            pictureBoxHealth.Name = "pictureBoxHealth";
            pictureBoxHealth.Size = new Size(40, 40);
            pictureBoxHealth.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHealth.TabIndex = 1;
            pictureBoxHealth.TabStop = false;
            pictureBoxHealth.MouseEnter += HealthInfo_MouseEnter;
            pictureBoxHealth.MouseLeave += HealthInfo_MouseLeave;
            // 
            // labelHealth
            // 
            labelHealth.Font = new Font("黑体", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelHealth.ForeColor = Color.Red;
            labelHealth.Location = new Point(46, 0);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(75, 41);
            labelHealth.TabIndex = 2;
            labelHealth.Text = "80/80";
            labelHealth.TextAlign = ContentAlignment.MiddleCenter;
            labelHealth.MouseEnter += HealthInfo_MouseEnter;
            labelHealth.MouseLeave += HealthInfo_MouseLeave;
            // 
            // HealthInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHealth);
            Controls.Add(pictureBoxHealth);
            Name = "HealthInfo";
            Size = new Size(124, 41);
            MouseEnter += HealthInfo_MouseEnter;
            MouseLeave += HealthInfo_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHealth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxHealth;
        private Label labelHealth;
    }
}
