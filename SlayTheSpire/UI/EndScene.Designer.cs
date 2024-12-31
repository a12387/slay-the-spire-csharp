namespace SlayTheSpire.UI
{
    partial class EndScene
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
            labelMessage = new Label();
            buttonReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.corpse;
            pictureBox1.Location = new Point(440, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelMessage
            // 
            labelMessage.BackColor = Color.Transparent;
            labelMessage.Font = new Font("Microsoft YaHei UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelMessage.ForeColor = Color.Red;
            labelMessage.Location = new Point(440, 29);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(400, 200);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "YOU DIED!";
            labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            buttonReturn.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            buttonReturn.Location = new Point(540, 600);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(200, 80);
            buttonReturn.TabIndex = 2;
            buttonReturn.Text = "返回主界面";
            buttonReturn.UseVisualStyleBackColor = true;
            buttonReturn.Click += buttonReturn_Click;
            // 
            // EndScene
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scene;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(buttonReturn);
            Controls.Add(labelMessage);
            Controls.Add(pictureBox1);
            Name = "EndScene";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelMessage;
        private Button buttonReturn;
    }
}
