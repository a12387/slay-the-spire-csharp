namespace SlayTheSpire.UI
{
    partial class OperationArea
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
            pictureBox2 = new PictureBox();
            labelEnergy = new Label();
            labelExhaust = new Label();
            panelHand = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.deck1;
            pictureBox1.Location = new Point(0, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.discard;
            pictureBox2.Location = new Point(1160, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelEnergy
            // 
            labelEnergy.Location = new Point(0, 30);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(120, 120);
            labelEnergy.TabIndex = 2;
            labelEnergy.Text = "4/4";
            labelEnergy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelExhaust
            // 
            labelExhaust.Location = new Point(1160, 30);
            labelExhaust.Name = "labelExhaust";
            labelExhaust.Size = new Size(120, 120);
            labelExhaust.TabIndex = 3;
            labelExhaust.Text = "0";
            labelExhaust.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHand
            // 
            panelHand.AutoScroll = true;
            panelHand.Location = new Point(120, 0);
            panelHand.Name = "panelHand";
            panelHand.Size = new Size(1040, 270);
            panelHand.TabIndex = 4;
            // 
            // OperationArea
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelHand);
            Controls.Add(labelExhaust);
            Controls.Add(labelEnergy);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "OperationArea";
            Size = new Size(1280, 270);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelEnergy;
        private Label labelExhaust;
        private Panel panelHand;
    }
}
