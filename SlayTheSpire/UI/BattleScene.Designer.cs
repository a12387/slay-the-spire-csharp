namespace SlayTheSpire.UI
{
    partial class BattleScene
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
            operationArea = new OperationArea();
            panelPlayerLeft = new Panel();
            panelPlayerMiddle = new Panel();
            panelMonsterLeft = new Panel();
            panelMonsterRight = new Panel();
            panelPlayerLeft.SuspendLayout();
            SuspendLayout();
            // 
            // operationArea
            // 
            operationArea.BackColor = Color.Transparent;
            operationArea.Location = new Point(0, 450);
            operationArea.Name = "operationArea";
            operationArea.Size = new Size(1280, 270);
            operationArea.TabIndex = 1;
            // 
            // panelPlayerLeft
            // 
            panelPlayerLeft.BackColor = Color.Transparent;
            panelPlayerLeft.Controls.Add(panelPlayerMiddle);
            panelPlayerLeft.Location = new Point(70, 74);
            panelPlayerLeft.Name = "panelPlayerLeft";
            panelPlayerLeft.Size = new Size(393, 370);
            panelPlayerLeft.TabIndex = 2;
            // 
            // panelPlayerMiddle
            // 
            panelPlayerMiddle.BackColor = Color.Transparent;
            panelPlayerMiddle.Location = new Point(373, 0);
            panelPlayerMiddle.Name = "panelPlayerMiddle";
            panelPlayerMiddle.Size = new Size(383, 370);
            panelPlayerMiddle.TabIndex = 2;
            // 
            // panelMonsterLeft
            // 
            panelMonsterLeft.BackColor = Color.Transparent;
            panelMonsterLeft.Location = new Point(70, 71);
            panelMonsterLeft.Name = "panelMonsterLeft";
            panelMonsterLeft.Size = new Size(393, 373);
            panelMonsterLeft.TabIndex = 2;
            // 
            // panelMonsterRight
            // 
            panelMonsterRight.BackColor = Color.Transparent;
            panelMonsterRight.Location = new Point(832, 71);
            panelMonsterRight.Name = "panelMonsterRight";
            panelMonsterRight.Size = new Size(406, 373);
            panelMonsterRight.TabIndex = 2;
            // 
            // BattleScene
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scene;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panelMonsterRight);
            Controls.Add(panelMonsterLeft);
            Controls.Add(panelPlayerLeft);
            Controls.Add(operationArea);
            Name = "BattleScene";
            Size = new Size(1280, 720);
            panelPlayerLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OperationArea operationArea;
        private Panel panelPlayerLeft;
        private Panel panelPlayerMiddle;
        private Panel panelMonsterLeft;
        private Panel panelMonsterRight;
    }
}
