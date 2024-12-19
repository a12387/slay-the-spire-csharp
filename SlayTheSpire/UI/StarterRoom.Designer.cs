namespace SlayTheSpire
{
    partial class StarterRoom
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
            buttonTalk = new Button();
            buttonGetDeck = new Button();
            buttonLeave = new Button();
            playerInfo = new UI.PlayerInfo();
            pictureBoxHeart = new PictureBox();
            pictureBoxDialog = new PictureBox();
            labelDialog = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDialog).BeginInit();
            SuspendLayout();
            // 
            // buttonTalk
            // 
            buttonTalk.Location = new Point(84, 555);
            buttonTalk.Name = "buttonTalk";
            buttonTalk.Size = new Size(194, 47);
            buttonTalk.TabIndex = 0;
            buttonTalk.Text = "Talk";
            buttonTalk.UseVisualStyleBackColor = true;
            buttonTalk.Click += buttonTalk_Click;
            // 
            // buttonGetDeck
            // 
            buttonGetDeck.Location = new Point(84, 555);
            buttonGetDeck.Name = "buttonGetDeck";
            buttonGetDeck.Size = new Size(194, 47);
            buttonGetDeck.TabIndex = 1;
            buttonGetDeck.Text = "GetDeck";
            buttonGetDeck.UseVisualStyleBackColor = true;
            buttonGetDeck.Visible = false;
            buttonGetDeck.Click += buttonGetDeck_Click;
            // 
            // buttonLeave
            // 
            buttonLeave.Location = new Point(84, 555);
            buttonLeave.Name = "buttonLeave";
            buttonLeave.Size = new Size(194, 47);
            buttonLeave.TabIndex = 2;
            buttonLeave.Text = "Leave";
            buttonLeave.UseVisualStyleBackColor = true;
            buttonLeave.Visible = false;
            buttonLeave.Click += StartJourney;
            // 
            // playerInfo
            // 
            playerInfo.BackColor = Color.FromArgb(65, 76, 81);
            playerInfo.Location = new Point(0, 0);
            playerInfo.Name = "playerInfo";
            playerInfo.Size = new Size(1280, 40);
            playerInfo.TabIndex = 3;
            // 
            // pictureBoxHeart
            // 
            pictureBoxHeart.BackColor = Color.Transparent;
            pictureBoxHeart.Image = Properties.Resources.CorruptHeart;
            pictureBoxHeart.Location = new Point(791, 40);
            pictureBoxHeart.Margin = new Padding(0);
            pictureBoxHeart.Name = "pictureBoxHeart";
            pictureBoxHeart.Size = new Size(436, 488);
            pictureBoxHeart.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHeart.TabIndex = 4;
            pictureBoxHeart.TabStop = false;
            // 
            // pictureBoxDialog
            // 
            pictureBoxDialog.BackColor = Color.Transparent;
            pictureBoxDialog.Image = Properties.Resources.speechBubble2;
            pictureBoxDialog.Location = new Point(451, 171);
            pictureBoxDialog.Name = "pictureBoxDialog";
            pictureBoxDialog.Size = new Size(409, 357);
            pictureBoxDialog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDialog.TabIndex = 5;
            pictureBoxDialog.TabStop = false;
            // 
            // labelDialog
            // 
            labelDialog.AutoSize = true;
            labelDialog.Font = new Font("黑体", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelDialog.Location = new Point(577, 338);
            labelDialog.Name = "labelDialog";
            labelDialog.Size = new Size(43, 22);
            labelDialog.TabIndex = 6;
            labelDialog.Text = "...";
            // 
            // StarterRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scene;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(labelDialog);
            Controls.Add(playerInfo);
            Controls.Add(pictureBoxHeart);
            Controls.Add(pictureBoxDialog);
            Controls.Add(buttonLeave);
            Controls.Add(buttonGetDeck);
            Controls.Add(buttonTalk);
            Name = "StarterRoom";
            Size = new Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBoxHeart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDialog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTalk;
        private Button buttonGetDeck;
        private Button buttonLeave;
        private UI.PlayerInfo playerInfo;
        private PictureBox pictureBoxHeart;
        private PictureBox pictureBoxDialog;
        private Label labelDialog;
    }
}
