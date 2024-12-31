namespace SlayTheSpire.UI
{
    partial class BuffUI
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
            myPictureBox1 = new MyPictureBox();
            panelBuffUI = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)myPictureBox1).BeginInit();
            panelBuffUI.SuspendLayout();
            SuspendLayout();
            // 
            // myPictureBox1
            // 
            myPictureBox1.BackGroundA = 0;
            myPictureBox1.Location = new Point(0, 0);
            myPictureBox1.Name = "myPictureBox1";
            myPictureBox1.Size = new Size(30, 30);
            myPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            myPictureBox1.TabIndex = 0;
            myPictureBox1.TabStop = false;
            // 
            // panelBuffUI
            // 
            panelBuffUI.Controls.Add(label1);
            panelBuffUI.Location = new Point(1, 1);
            panelBuffUI.Name = "panelBuffUI";
            panelBuffUI.Size = new Size(28, 28);
            panelBuffUI.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(28, 28);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // BuffUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBuffUI);
            Controls.Add(myPictureBox1);
            Margin = new Padding(0);
            Name = "BuffUI";
            Size = new Size(30, 30);
            ((System.ComponentModel.ISupportInitialize)myPictureBox1).EndInit();
            panelBuffUI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MyPictureBox myPictureBox1;
        private Panel panelBuffUI;
        private Label label1;
    }
}
