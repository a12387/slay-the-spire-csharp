namespace SlayTheSpire.UI
{
    partial class CardSelection
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
            myPictureBoxBackground = new MyPictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxBackground).BeginInit();
            SuspendLayout();
            // 
            // myPictureBoxBackground
            // 
            myPictureBoxBackground.Dock = DockStyle.Fill;
            myPictureBoxBackground.Location = new Point(0, 0);
            myPictureBoxBackground.Name = "myPictureBoxBackground";
            myPictureBoxBackground.Size = new Size(1280, 720);
            myPictureBoxBackground.TabIndex = 0;
            myPictureBoxBackground.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(320, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 252);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(780, 220);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 252);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(550, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 252);
            panel2.TabIndex = 3;
            // 
            // CardSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(myPictureBoxBackground);
            Name = "CardSelection";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)myPictureBoxBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MyPictureBox myPictureBoxBackground;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
    }
}
