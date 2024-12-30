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
            labelHealth = new Label();
            SuspendLayout();
            // 
            // labelHealth
            // 
            labelHealth.BackColor = Color.Transparent;
            labelHealth.BorderStyle = BorderStyle.FixedSingle;
            labelHealth.Dock = DockStyle.Fill;
            labelHealth.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelHealth.ForeColor = Color.Transparent;
            labelHealth.Location = new Point(0, 0);
            labelHealth.Margin = new Padding(0);
            labelHealth.Name = "labelHealth";
            labelHealth.Size = new Size(273, 38);
            labelHealth.TabIndex = 1;
            labelHealth.Text = "80/80";
            labelHealth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HealthBar
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(labelHealth);
            Name = "HealthBar";
            Size = new Size(273, 38);
            ResumeLayout(false);
        }

        #endregion

        private Label labelHealth;
    }
}
