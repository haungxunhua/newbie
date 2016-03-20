namespace library
{
    partial class books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除图书ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.清空图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书ToolStripMenuItem,
            this.借阅人ToolStripMenuItem,
            this.文件ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.借阅ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书ToolStripMenuItem
            // 
            this.图书ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加图书ToolStripMenuItem,
            this.查询图书ToolStripMenuItem,
            this.删除图书ToolStripMenuItem1,
            this.清空图书ToolStripMenuItem});
            this.图书ToolStripMenuItem.Name = "图书ToolStripMenuItem";
            this.图书ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.图书ToolStripMenuItem.Text = "图书";
            // 
            // 增加图书ToolStripMenuItem
            // 
            this.增加图书ToolStripMenuItem.Name = "增加图书ToolStripMenuItem";
            this.增加图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.增加图书ToolStripMenuItem.Text = "增加图书";
            this.增加图书ToolStripMenuItem.Click += new System.EventHandler(this.增加图书ToolStripMenuItem_Click);
            // 
            // 查询图书ToolStripMenuItem
            // 
            this.查询图书ToolStripMenuItem.Name = "查询图书ToolStripMenuItem";
            this.查询图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查询图书ToolStripMenuItem.Text = "查询图书";
            this.查询图书ToolStripMenuItem.Click += new System.EventHandler(this.查询图书ToolStripMenuItem_Click);
            // 
            // 删除图书ToolStripMenuItem1
            // 
            this.删除图书ToolStripMenuItem1.Name = "删除图书ToolStripMenuItem1";
            this.删除图书ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.删除图书ToolStripMenuItem1.Text = "删除图书";
            this.删除图书ToolStripMenuItem1.Click += new System.EventHandler(this.删除图书ToolStripMenuItem1_Click);
            // 
            // 清空图书ToolStripMenuItem
            // 
            this.清空图书ToolStripMenuItem.Name = "清空图书ToolStripMenuItem";
            this.清空图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空图书ToolStripMenuItem.Text = "清空图书";
            this.清空图书ToolStripMenuItem.Click += new System.EventHandler(this.清空图书ToolStripMenuItem_Click);
            // 
            // 借阅人ToolStripMenuItem
            // 
            this.借阅人ToolStripMenuItem.Name = "借阅人ToolStripMenuItem";
            this.借阅人ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.借阅人ToolStripMenuItem.Text = "借阅人";
            this.借阅人ToolStripMenuItem.Click += new System.EventHandler(this.借阅人ToolStripMenuItem_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(844, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // 借阅ToolStripMenuItem
            // 
            this.借阅ToolStripMenuItem.Name = "借阅ToolStripMenuItem";
            this.借阅ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.借阅ToolStripMenuItem.Text = "借阅";
            this.借阅ToolStripMenuItem.Click += new System.EventHandler(this.借阅ToolStripMenuItem_Click);
            // 
            // books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 419);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "books";
            this.Text = "books";
            this.Load += new System.EventHandler(this.books_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除图书ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 借阅人ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅ToolStripMenuItem;
    }
}