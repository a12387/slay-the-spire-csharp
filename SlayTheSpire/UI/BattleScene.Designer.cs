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
            panelLeft = new Panel();
            panelRight = new Panel();
            panelMiddle = new Panel();
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
            // panelLeft
            // 
            panelLeft.BackColor = Color.Transparent;
            panelLeft.Location = new Point(70, 71);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(393, 373);
            panelLeft.TabIndex = 2;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.Transparent;
            panelRight.Location = new Point(832, 71);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(406, 373);
            panelRight.TabIndex = 2;
            // 
            // panelMiddle
            // 
            panelMiddle.BackColor = Color.Transparent;
            panelMiddle.Location = new Point(460, 68);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(393, 373);
            panelMiddle.TabIndex = 3;
            // 
            // BattleScene
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scene;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(operationArea);
            Controls.Add(panelMiddle);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Name = "BattleScene";
            Size = new Size(1280, 720);
            ResumeLayout(false);
        }

        #endregion
        private OperationArea operationArea;
        private Panel panelLeft;
        private Panel panelRight;
        private Panel panelMiddle;
    }
}
