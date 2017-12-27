namespace cross2
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.compu_pic = new System.Windows.Forms.PictureBox();
            this.human_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新手上路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专业玩家ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个性化设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.现代元素ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.古典元素ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.抽象元素ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.玩家登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.井字棋规则介绍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开发团队ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compu_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.human_pic)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(49, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 16F);
            this.label3.Location = new System.Drawing.Point(429, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "请点击“开始游戏”";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton1.Location = new System.Drawing.Point(482, 213);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 20);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "玩家先手";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.radioButton2.Location = new System.Drawing.Point(482, 248);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 20);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "电脑先手";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("宋体", 16F);
            this.button1.Location = new System.Drawing.Point(471, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "开始游戏";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // compu_pic
            // 
            this.compu_pic.Image = ((System.Drawing.Image)(resources.GetObject("compu_pic.Image")));
            this.compu_pic.Location = new System.Drawing.Point(465, 142);
            this.compu_pic.Margin = new System.Windows.Forms.Padding(2);
            this.compu_pic.Name = "compu_pic";
            this.compu_pic.Size = new System.Drawing.Size(40, 40);
            this.compu_pic.TabIndex = 9;
            this.compu_pic.TabStop = false;
            // 
            // human_pic
            // 
            this.human_pic.Image = ((System.Drawing.Image)(resources.GetObject("human_pic.Image")));
            this.human_pic.Location = new System.Drawing.Point(465, 83);
            this.human_pic.Margin = new System.Windows.Forms.Padding(2);
            this.human_pic.Name = "human_pic";
            this.human_pic.Size = new System.Drawing.Size(40, 40);
            this.human_pic.TabIndex = 10;
            this.human_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(509, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = " 玩家棋子";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(517, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "电脑棋子";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.登录ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于我们ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.个性化设置ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            this.游戏ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.游戏ToolStripMenuItem.Text = "开始(&S)";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新手上路ToolStripMenuItem,
            this.专业玩家ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开始ToolStripMenuItem.Text = "难度选择(&D)";
            // 
            // 新手上路ToolStripMenuItem
            // 
            this.新手上路ToolStripMenuItem.Name = "新手上路ToolStripMenuItem";
            this.新手上路ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.新手上路ToolStripMenuItem.Text = "新手上路(&E)";
            this.新手上路ToolStripMenuItem.Click += new System.EventHandler(this.新手上路ToolStripMenuItem_Click_1);
            // 
            // 专业玩家ToolStripMenuItem
            // 
            this.专业玩家ToolStripMenuItem.Name = "专业玩家ToolStripMenuItem";
            this.专业玩家ToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.专业玩家ToolStripMenuItem.Text = "专业玩家(&H)";
            this.专业玩家ToolStripMenuItem.Click += new System.EventHandler(this.专业玩家ToolStripMenuItem_Click_1);
            // 
            // 个性化设置ToolStripMenuItem
            // 
            this.个性化设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.现代元素ToolStripMenuItem1,
            this.古典元素ToolStripMenuItem1,
            this.抽象元素ToolStripMenuItem1});
            this.个性化设置ToolStripMenuItem.Name = "个性化设置ToolStripMenuItem";
            this.个性化设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.个性化设置ToolStripMenuItem.Text = "个性化设置(&R)";
            // 
            // 现代元素ToolStripMenuItem1
            // 
            this.现代元素ToolStripMenuItem1.Name = "现代元素ToolStripMenuItem1";
            this.现代元素ToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.现代元素ToolStripMenuItem1.Text = "现代元素(&M)";
            this.现代元素ToolStripMenuItem1.Click += new System.EventHandler(this.现代元素ToolStripMenuItem1_Click);
            // 
            // 古典元素ToolStripMenuItem1
            // 
            this.古典元素ToolStripMenuItem1.Name = "古典元素ToolStripMenuItem1";
            this.古典元素ToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.古典元素ToolStripMenuItem1.Text = "古典元素(&C)";
            this.古典元素ToolStripMenuItem1.Click += new System.EventHandler(this.古典元素ToolStripMenuItem1_Click);
            // 
            // 抽象元素ToolStripMenuItem1
            // 
            this.抽象元素ToolStripMenuItem1.Name = "抽象元素ToolStripMenuItem1";
            this.抽象元素ToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.抽象元素ToolStripMenuItem1.Text = "抽象元素(&A)";
            this.抽象元素ToolStripMenuItem1.Click += new System.EventHandler(this.抽象元素ToolStripMenuItem1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出(&X)";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.玩家登录ToolStripMenuItem,
            this.查询成绩ToolStripMenuItem});
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.登录ToolStripMenuItem.Text = "用户(&P)";
            // 
            // 玩家登录ToolStripMenuItem
            // 
            this.玩家登录ToolStripMenuItem.Name = "玩家登录ToolStripMenuItem";
            this.玩家登录ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.玩家登录ToolStripMenuItem.Text = "玩家登录(&L)";
            this.玩家登录ToolStripMenuItem.Click += new System.EventHandler(this.玩家登录ToolStripMenuItem_Click);
            // 
            // 查询成绩ToolStripMenuItem
            // 
            this.查询成绩ToolStripMenuItem.Name = "查询成绩ToolStripMenuItem";
            this.查询成绩ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.查询成绩ToolStripMenuItem.Text = "查询成绩(&Q)";
            this.查询成绩ToolStripMenuItem.Click += new System.EventHandler(this.查询成绩ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.井字棋规则介绍ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 井字棋规则介绍ToolStripMenuItem
            // 
            this.井字棋规则介绍ToolStripMenuItem.Name = "井字棋规则介绍ToolStripMenuItem";
            this.井字棋规则介绍ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.井字棋规则介绍ToolStripMenuItem.Text = "规则介绍(&I)";
            this.井字棋规则介绍ToolStripMenuItem.Click += new System.EventHandler(this.井字棋规则介绍ToolStripMenuItem_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开发团队ToolStripMenuItem});
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于我们ToolStripMenuItem.Text = "关于(&A)";
            // 
            // 开发团队ToolStripMenuItem
            // 
            this.开发团队ToolStripMenuItem.Name = "开发团队ToolStripMenuItem";
            this.开发团队ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.开发团队ToolStripMenuItem.Text = "开发团队(&T)";
            this.开发团队ToolStripMenuItem.Click += new System.EventHandler(this.开发团队ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "现代元素背景.jpg");
            this.imageList1.Images.SetKeyName(1, "古典元素背景.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cross2.Properties.Resources.现代元素背景;
            this.ClientSize = new System.Drawing.Size(695, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.human_pic);
            this.Controls.Add(this.compu_pic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compu_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.human_pic)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox compu_pic;
        private System.Windows.Forms.PictureBox human_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 井字棋规则介绍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新手上路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专业玩家ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开发团队ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 玩家登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个性化设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 现代元素ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 古典元素ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 抽象元素ToolStripMenuItem1;
    }
}

