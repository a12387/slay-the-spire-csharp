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
            pictureBoxDrawPile = new PictureBox();
            pictureBoxDiscardPile = new PictureBox();
            labelEnergy = new Label();
            labelExhaust = new Label();
            panelHand = new Panel();
            buttonEndTurn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrawPile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiscardPile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDrawPile
            // 
            pictureBoxDrawPile.BackColor = Color.Transparent;
            pictureBoxDrawPile.Image = Properties.Resources.deck1;
            pictureBoxDrawPile.Location = new Point(0, 150);
            pictureBoxDrawPile.Margin = new Padding(0);
            pictureBoxDrawPile.Name = "pictureBoxDrawPile";
            pictureBoxDrawPile.Size = new Size(120, 120);
            pictureBoxDrawPile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDrawPile.TabIndex = 0;
            pictureBoxDrawPile.TabStop = false;
            // 
            // pictureBoxDiscardPile
            // 
            pictureBoxDiscardPile.Image = Properties.Resources.discard;
            pictureBoxDiscardPile.Location = new Point(1160, 150);
            pictureBoxDiscardPile.Margin = new Padding(0);
            pictureBoxDiscardPile.Name = "pictureBoxDiscardPile";
            pictureBoxDiscardPile.Size = new Size(120, 120);
            pictureBoxDiscardPile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDiscardPile.TabIndex = 1;
            pictureBoxDiscardPile.TabStop = false;
            // 
            // labelEnergy
            // 
            labelEnergy.Location = new Point(0, 30);
            labelEnergy.Margin = new Padding(0);
            labelEnergy.Name = "labelEnergy";
            labelEnergy.Size = new Size(120, 120);
            labelEnergy.TabIndex = 2;
            labelEnergy.Text = "4/4";
            labelEnergy.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelExhaust
            // 
            labelExhaust.Location = new Point(1160, 48);
            labelExhaust.Margin = new Padding(0);
            labelExhaust.Name = "labelExhaust";
            labelExhaust.Size = new Size(120, 102);
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
            // buttonEndTurn
            // 
            buttonEndTurn.BackColor = Color.Transparent;
            buttonEndTurn.BackgroundImage = Properties.Resources.endturn1;
            buttonEndTurn.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEndTurn.Enabled = false;
            buttonEndTurn.FlatAppearance.BorderSize = 0;
            buttonEndTurn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonEndTurn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonEndTurn.FlatStyle = FlatStyle.Flat;
            buttonEndTurn.Location = new Point(1160, 0);
            buttonEndTurn.Margin = new Padding(0);
            buttonEndTurn.Name = "buttonEndTurn";
            buttonEndTurn.Size = new Size(120, 48);
            buttonEndTurn.TabIndex = 5;
            buttonEndTurn.Text = "EndTurn";
            buttonEndTurn.UseVisualStyleBackColor = false;
            buttonEndTurn.Click += buttonEndTurn_Click;
            // 
            // OperationArea
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(buttonEndTurn);
            Controls.Add(panelHand);
            Controls.Add(labelExhaust);
            Controls.Add(labelEnergy);
            Controls.Add(pictureBoxDiscardPile);
            Controls.Add(pictureBoxDrawPile);
            Name = "OperationArea";
            Size = new Size(1280, 270);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDrawPile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDiscardPile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxDrawPile;
        private PictureBox pictureBoxDiscardPile;
        private Label labelEnergy;
        private Label labelExhaust;
        private Panel panelHand;
        private Button buttonEndTurn;
    }
}
