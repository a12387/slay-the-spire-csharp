namespace SlayTheSpire.UI
{
    partial class PileView
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
            buttonOK = new Button();
            panel1 = new Panel();
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
            // buttonOK
            // 
            buttonOK.Location = new Point(580, 600);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(120, 90);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "完成";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 720);
            panel1.TabIndex = 2;
            // 
            // PileView
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonOK);
            Controls.Add(panel1);
            Controls.Add(myPictureBoxBackground);
            Name = "PileView";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)myPictureBoxBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MyPictureBox myPictureBoxBackground;
        private Button buttonOK;
        private Panel panel1;
    }
}
