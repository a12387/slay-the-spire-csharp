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
            SuspendLayout();
            // 
            // buttonTalk
            // 
            buttonTalk.Location = new Point(163, 531);
            buttonTalk.Name = "buttonTalk";
            buttonTalk.Size = new Size(194, 94);
            buttonTalk.TabIndex = 0;
            buttonTalk.Text = "Talk";
            buttonTalk.UseVisualStyleBackColor = true;
            // 
            // buttonGetDeck
            // 
            buttonGetDeck.Location = new Point(418, 531);
            buttonGetDeck.Name = "buttonGetDeck";
            buttonGetDeck.Size = new Size(194, 94);
            buttonGetDeck.TabIndex = 1;
            buttonGetDeck.Text = "GetDeck";
            buttonGetDeck.UseVisualStyleBackColor = true;
            // 
            // buttonLeave
            // 
            buttonLeave.Location = new Point(671, 531);
            buttonLeave.Name = "buttonLeave";
            buttonLeave.Size = new Size(194, 94);
            buttonLeave.TabIndex = 2;
            buttonLeave.Text = "Leave";
            buttonLeave.UseVisualStyleBackColor = true;
            buttonLeave.Click += StartJourney;
            // 
            // StarterRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonLeave);
            Controls.Add(buttonGetDeck);
            Controls.Add(buttonTalk);
            Name = "StarterRoom";
            Size = new Size(1280, 720);
            Click += StartJourney;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTalk;
        private Button buttonGetDeck;
        private Button buttonLeave;
    }
}
