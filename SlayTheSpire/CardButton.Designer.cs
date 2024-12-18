namespace SlayTheSpire
{
    partial class CardButton
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
            labelDescription = new Label();
            pictureBoxFrame = new PictureBox();
            pictureBoxImage = new PictureBox();
            pictureBoxBanner = new PictureBox();
            labelName = new Label();
            pictureBoxCost = new PictureBox();
            labelCost = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCost).BeginInit();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(20, 150);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(140, 90);
            labelDescription.TabIndex = 0;
            labelDescription.Text = "label1";
            labelDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBoxFrame
            // 
            pictureBoxFrame.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxFrame.Location = new Point(10, 35);
            pictureBoxFrame.Name = "pictureBoxFrame";
            pictureBoxFrame.Size = new Size(162, 113);
            pictureBoxFrame.TabIndex = 1;
            pictureBoxFrame.TabStop = false;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImage.Location = new Point(12, 24);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(160, 122);
            pictureBoxImage.TabIndex = 2;
            pictureBoxImage.TabStop = false;
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxBanner.Location = new Point(0, 0);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(180, 50);
            pictureBoxBanner.TabIndex = 3;
            pictureBoxBanner.TabStop = false;
            // 
            // labelName
            // 
            labelName.Font = new Font("Microsoft YaHei UI", 14F);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(0, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(180, 30);
            labelName.TabIndex = 4;
            labelName.Text = "labelName";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCost
            // 
            pictureBoxCost.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCost.Location = new Point(0, 0);
            pictureBoxCost.Name = "pictureBoxCost";
            pictureBoxCost.Size = new Size(31, 31);
            pictureBoxCost.TabIndex = 5;
            pictureBoxCost.TabStop = false;
            // 
            // labelCost
            // 
            labelCost.Font = new Font("Microsoft YaHei UI", 14F);
            labelCost.ForeColor = Color.White;
            labelCost.Location = new Point(0, 0);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(31, 31);
            labelCost.TabIndex = 6;
            labelCost.Text = "114";
            labelCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardButton
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(labelName);
            Controls.Add(labelCost);
            Controls.Add(pictureBoxImage);
            Controls.Add(pictureBoxFrame);
            Controls.Add(labelDescription);
            Controls.Add(pictureBoxCost);
            Controls.Add(pictureBoxBanner);
            Name = "CardButton";
            Size = new Size(180, 252);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelDescription;
        private PictureBox pictureBoxFrame;
        private PictureBox pictureBoxImage;
        private PictureBox pictureBoxBanner;
        private Label labelName;
        private PictureBox pictureBoxCost;
        private Label labelCost;
    }
}
