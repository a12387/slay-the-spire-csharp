namespace SlayTheSpire.UI
{
    partial class PlayerInfo
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
            labelPlayerName = new Label();
            labelCharacter = new Label();
            pictureBoxMap = new PictureBox();
            pictureBoxDeck = new PictureBox();
            healthInfo = new HealthInfo();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeck).BeginInit();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.Font = new Font("黑体", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelPlayerName.ForeColor = SystemColors.ButtonHighlight;
            labelPlayerName.Location = new Point(3, 0);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(97, 40);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "C小#";
            labelPlayerName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCharacter
            // 
            labelCharacter.Font = new Font("等线", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelCharacter.ForeColor = SystemColors.HighlightText;
            labelCharacter.Location = new Point(106, 0);
            labelCharacter.Name = "labelCharacter";
            labelCharacter.Size = new Size(81, 40);
            labelCharacter.TabIndex = 0;
            labelCharacter.Text = "铁甲战士";
            labelCharacter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxMap
            // 
            pictureBoxMap.Image = Properties.Resources.map;
            pictureBoxMap.Location = new Point(1158, -1);
            pictureBoxMap.Name = "pictureBoxMap";
            pictureBoxMap.Size = new Size(40, 40);
            pictureBoxMap.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMap.TabIndex = 1;
            pictureBoxMap.TabStop = false;
            pictureBoxMap.Click += pictureBoxMap_Click;
            // 
            // pictureBoxDeck
            // 
            pictureBoxDeck.Image = Properties.Resources.deck;
            pictureBoxDeck.Location = new Point(1218, -1);
            pictureBoxDeck.Name = "pictureBoxDeck";
            pictureBoxDeck.Size = new Size(40, 40);
            pictureBoxDeck.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDeck.TabIndex = 1;
            pictureBoxDeck.TabStop = false;
            pictureBoxDeck.Click += pictureBoxDeck_Click;
            // 
            // healthInfo
            // 
            healthInfo.CurrentHealth = 80;
            healthInfo.Location = new Point(219, -1);
            healthInfo.MaxHealth = 80;
            healthInfo.Name = "healthInfo";
            healthInfo.Size = new Size(124, 41);
            healthInfo.TabIndex = 2;
            // 
            // PlayerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 76, 81);
            Controls.Add(healthInfo);
            Controls.Add(pictureBoxDeck);
            Controls.Add(pictureBoxMap);
            Controls.Add(labelCharacter);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfo";
            Size = new Size(1280, 40);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDeck).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelPlayerName;
        private Label labelCharacter;
        private PictureBox pictureBoxMap;
        private PictureBox pictureBoxDeck;
        private HealthInfo healthInfo;
    }
}
