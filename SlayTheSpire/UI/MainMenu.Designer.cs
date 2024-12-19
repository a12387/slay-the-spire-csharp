namespace SlayTheSpire.UI
{
    partial class MainMenu
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
            buttonStart = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Transparent;
            buttonStart.Font = new Font("黑体", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonStart.Location = new Point(88, 432);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(158, 52);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "开始游戏";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.MouseClick += GameStart;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.eng;
            pictureBox1.Location = new Point(390, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(buttonStart);
            Name = "MainMenu";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStart;
        private PictureBox pictureBox1;
    }
}
