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
            buttonElite = new Button();
            buttonBoss = new Button();
            SuspendLayout();
            // 
            // buttonElite
            // 
            buttonElite.Location = new Point(552, 347);
            buttonElite.Name = "buttonElite";
            buttonElite.Size = new Size(75, 23);
            buttonElite.TabIndex = 0;
            buttonElite.Text = "button1";
            buttonElite.UseVisualStyleBackColor = true;
            // 
            // buttonBoss
            // 
            buttonBoss.Location = new Point(552, 220);
            buttonBoss.Name = "buttonBoss";
            buttonBoss.Size = new Size(75, 23);
            buttonBoss.TabIndex = 1;
            buttonBoss.Text = "button2";
            buttonBoss.UseVisualStyleBackColor = true;
            // 
            // GameMap
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(buttonBoss);
            Controls.Add(buttonElite);
            Name = "GameMap";
            Size = new Size(1280, 720);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonElite;
        private Button buttonBoss;
    }
}
