namespace WADmanage
{
    partial class Manage
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缴费管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缴费记录管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.费用设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.水费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.缴费管理ToolStripMenuItem,
            this.缴费记录管理ToolStripMenuItem,
            this.费用设置ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 缴费管理ToolStripMenuItem
            // 
            this.缴费管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水费ToolStripMenuItem,
            this.电费ToolStripMenuItem});
            this.缴费管理ToolStripMenuItem.Name = "缴费管理ToolStripMenuItem";
            this.缴费管理ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.缴费管理ToolStripMenuItem.Text = "缴费管理";
            // 
            // 缴费记录管理ToolStripMenuItem
            // 
            this.缴费记录管理ToolStripMenuItem.Name = "缴费记录管理ToolStripMenuItem";
            this.缴费记录管理ToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.缴费记录管理ToolStripMenuItem.Text = "缴费记录管理";
            this.缴费记录管理ToolStripMenuItem.Click += new System.EventHandler(this.缴费记录管理ToolStripMenuItem_Click);
            // 
            // 费用设置ToolStripMenuItem
            // 
            this.费用设置ToolStripMenuItem.Name = "费用设置ToolStripMenuItem";
            this.费用设置ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.费用设置ToolStripMenuItem.Text = "费用设置";
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 347);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "(用户名)";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "欢迎您！";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton2.Text = "个人信息管理";
            // 
            // 水费ToolStripMenuItem
            // 
            this.水费ToolStripMenuItem.Name = "水费ToolStripMenuItem";
            this.水费ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.水费ToolStripMenuItem.Text = "水费";
            // 
            // 电费ToolStripMenuItem
            // 
            this.电费ToolStripMenuItem.Name = "电费ToolStripMenuItem";
            this.电费ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.电费ToolStripMenuItem.Text = "电费";
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manage";
            this.Text = "水电管理主页面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缴费管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缴费记录管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 费用设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem 水费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电费ToolStripMenuItem;
    }
}

