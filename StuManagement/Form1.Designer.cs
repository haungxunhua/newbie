namespace StuManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdsasdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.Location = new System.Drawing.Point(84, 43);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 23;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(445, 310);
            this.grid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdsasdfToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
            // 
            // fdsasdfToolStripMenuItem
            // 
            this.fdsasdfToolStripMenuItem.Name = "fdsasdfToolStripMenuItem";
            this.fdsasdfToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fdsasdfToolStripMenuItem.Text = "fdsasdf";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生ToolStripMenuItem,
            this.删除学生ToolStripMenuItem,
            this.查找学生ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // 添加学生ToolStripMenuItem
            // 
            this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加学生ToolStripMenuItem.Text = "添加学生";
            this.添加学生ToolStripMenuItem.Click += new System.EventHandler(this.添加学生ToolStripMenuItem_Click);
            // 
            // 删除学生ToolStripMenuItem
            // 
            this.删除学生ToolStripMenuItem.Name = "删除学生ToolStripMenuItem";
            this.删除学生ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除学生ToolStripMenuItem.Text = "删除学生";
            this.删除学生ToolStripMenuItem.Click += new System.EventHandler(this.删除学生ToolStripMenuItem_Click);
            // 
            // 查找学生ToolStripMenuItem
            // 
            this.查找学生ToolStripMenuItem.Name = "查找学生ToolStripMenuItem";
            this.查找学生ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查找学生ToolStripMenuItem.Text = "查找学生";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 419);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "学生信息管理Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fdsasdfToolStripMenuItem;
    }
}

