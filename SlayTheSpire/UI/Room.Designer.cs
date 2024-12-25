namespace SlayTheSpire.UI
{
    partial class Room
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
            playerInfo = new PlayerInfo();
            MainPanel = new Panel();
            SuspendLayout();
            // 
            // playerInfo
            // 
            playerInfo.BackColor = Color.FromArgb(65, 76, 81);
            playerInfo.Location = new Point(0, 0);
            playerInfo.Name = "playerInfo";
            playerInfo.Size = new Size(1280, 40);
            playerInfo.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1280, 720);
            MainPanel.TabIndex = 1;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(playerInfo);
            Controls.Add(MainPanel);
            Name = "Room";
            Size = new Size(1280, 720);
            ResumeLayout(false);
        }

        #endregion

        private PlayerInfo playerInfo;
        private Panel MainPanel;
    }
}
