namespace SlayTheSpire.UI
{
    partial class IntentUI
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
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)myPictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // myPictureBox1
            // 
            myPictureBox1.BackColor = Color.Transparent;
            myPictureBox1.BackGroundA = 0;
            myPictureBox1.Dock = DockStyle.Fill;
            myPictureBox1.Location = new Point(0, 0);
            myPictureBox1.Margin = new Padding(0);
            myPictureBox1.Name = "myPictureBox1";
            myPictureBox1.Size = new Size(250, 40);
            myPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            myPictureBox1.TabIndex = 0;
            myPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 40);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(250, 40);
            label1.TabIndex = 2;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // IntentUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(myPictureBox1);
            Name = "IntentUI";
            Size = new Size(250, 40);
            ((System.ComponentModel.ISupportInitialize)myPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MyPictureBox myPictureBox1;
        private Panel panel1;
        private Label label1;
    }
}
