namespace SlayTheSpire.UI
{
    partial class GameMap
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
            panelMap = new Panel();
            pictureBoxHeart = new PictureBox();
            pictureBoxElite = new PictureBox();
            myPictureBoxMap = new MyPictureBox();
            panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxMap).BeginInit();
            SuspendLayout();
            // 
            // panelMap
            // 
            panelMap.BackColor = Color.Transparent;
            panelMap.Controls.Add(pictureBoxHeart);
            panelMap.Controls.Add(pictureBoxElite);
            panelMap.Location = new Point(395, 73);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(469, 545);
            panelMap.TabIndex = 2;
            // 
            // pictureBoxHeart
            // 
            pictureBoxHeart.Image = Properties.Resources.heart;
            pictureBoxHeart.Location = new Point(71, 41);
            pictureBoxHeart.Name = "pictureBoxHeart";
            pictureBoxHeart.Size = new Size(333, 260);
            pictureBoxHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHeart.TabIndex = 3;
            pictureBoxHeart.TabStop = false;
            // 
            // pictureBoxElite
            // 
            pictureBoxElite.Image = Properties.Resources.elite;
            pictureBoxElite.Location = new Point(164, 384);
            pictureBoxElite.Name = "pictureBoxElite";
            pictureBoxElite.Size = new Size(137, 95);
            pictureBoxElite.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxElite.TabIndex = 3;
            pictureBoxElite.TabStop = false;
            pictureBoxElite.Click += pictureBoxElite_Click;
            // 
            // myPictureBoxMap
            // 
            myPictureBoxMap.Dock = DockStyle.Fill;
            myPictureBoxMap.Image = Properties.Resources.map1;
            myPictureBoxMap.Location = new Point(0, 0);
            myPictureBoxMap.Name = "myPictureBoxMap";
            myPictureBoxMap.Size = new Size(1280, 720);
            myPictureBoxMap.SizeMode = PictureBoxSizeMode.Zoom;
            myPictureBoxMap.TabIndex = 3;
            myPictureBoxMap.TabStop = false;
            // 
            // GameMap
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(panelMap);
            Controls.Add(myPictureBoxMap);
            DoubleBuffered = true;
            Name = "GameMap";
            Size = new Size(1280, 720);
            panelMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElite).EndInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxMap).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMap;
        private PictureBox pictureBoxElite;
        private PictureBox pictureBoxHeart;
        private MyPictureBox myPictureBoxMap;
    }
}
