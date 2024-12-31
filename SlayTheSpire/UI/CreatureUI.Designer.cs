namespace SlayTheSpire.UI
{
    partial class CreatureUI
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
            pictureBoxCreature = new PictureBox();
            healthBar = new HealthBar();
            buffBar = new BuffBar();
            pictureBoxWithLabel1 = new PictureBoxWithLabel();
            intentui1 = new IntentUI();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreature).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCreature
            // 
            pictureBoxCreature.Location = new Point(0, 40);
            pictureBoxCreature.Margin = new Padding(0);
            pictureBoxCreature.Name = "pictureBoxCreature";
            pictureBoxCreature.Size = new Size(250, 200);
            pictureBoxCreature.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCreature.TabIndex = 0;
            pictureBoxCreature.TabStop = false;
            // 
            // healthBar
            // 
            healthBar.BackColor = Color.Transparent;
            healthBar.CurrentBlock = 23;
            healthBar.CurrentHealth = 40;
            healthBar.Location = new Point(40, 250);
            healthBar.Margin = new Padding(0);
            healthBar.MaxHealth = 80;
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(210, 20);
            healthBar.TabIndex = 1;
            // 
            // buffBar
            // 
            buffBar.BackColor = Color.Transparent;
            buffBar.Location = new Point(40, 280);
            buffBar.Margin = new Padding(0);
            buffBar.Name = "buffBar";
            buffBar.Size = new Size(210, 30);
            buffBar.TabIndex = 2;
            // 
            // pictureBoxWithLabel1
            // 
            pictureBoxWithLabel1.BackColor = Color.Transparent;
            pictureBoxWithLabel1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            pictureBoxWithLabel1.Image = Properties.Resources.block;
            pictureBoxWithLabel1.labelText = "0";
            pictureBoxWithLabel1.Location = new Point(0, 240);
            pictureBoxWithLabel1.Margin = new Padding(0);
            pictureBoxWithLabel1.Name = "pictureBoxWithLabel1";
            pictureBoxWithLabel1.Size = new Size(40, 40);
            pictureBoxWithLabel1.TabIndex = 3;
            pictureBoxWithLabel1.Visible = false;
            // 
            // intentui1
            // 
            intentui1.Location = new Point(0, 0);
            intentui1.Margin = new Padding(0);
            intentui1.Name = "intentui1";
            intentui1.Size = new Size(250, 40);
            intentui1.TabIndex = 4;
            // 
            // CreatureUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(intentui1);
            Controls.Add(pictureBoxWithLabel1);
            Controls.Add(buffBar);
            Controls.Add(healthBar);
            Controls.Add(pictureBoxCreature);
            Margin = new Padding(0);
            Name = "CreatureUI";
            Size = new Size(250, 310);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxCreature;
        private HealthBar healthBar;
        private BuffBar buffBar;
        private PictureBoxWithLabel pictureBoxWithLabel1;
        private IntentUI intentui1;
    }
}
