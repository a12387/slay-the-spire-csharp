namespace SlayTheSpire.UI
{
    partial class HealthBar
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
            progressBar = new ProgressBar();
            labelHealth = new Label();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 9);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(224, 31);
            progressBar.TabIndex = 0;
            progressBar.Value = 100;
            // 
            // labelHealth
            // 
            labelHealth.BackColor = Color.Transparent;
            labelHealth.Location = new Point(12, 9);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(224, 31);
            labelHealth.TabIndex = 1;
            labelHealth.Text = "80/80";
            labelHealth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HealthBar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHealth);
            Controls.Add(progressBar);
            Name = "HealthBar";
            Size = new Size(250, 50);
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar;
        private Label labelHealth;
    }
}
