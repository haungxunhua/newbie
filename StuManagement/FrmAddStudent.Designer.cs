namespace StuManagement
{
    partial class FrmAddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHometown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LstFavs = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "年龄：";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TxtName.Location = new System.Drawing.Point(111, 26);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(180, 29);
            this.TxtName.TabIndex = 2;
            // 
            // numAge
            // 
            this.numAge.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numAge.Location = new System.Drawing.Point(111, 79);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(179, 29);
            this.numAge.TabIndex = 3;
            this.numAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(25, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdofemale);
            this.groupBox1.Controls.Add(this.rdomale);
            this.groupBox1.Location = new System.Drawing.Point(111, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdofemale.Location = new System.Drawing.Point(13, 57);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(46, 23);
            this.rdofemale.TabIndex = 1;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "女";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Checked = true;
            this.rdomale.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdomale.Location = new System.Drawing.Point(13, 22);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(46, 23);
            this.rdomale.TabIndex = 0;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "男";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(25, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "籍贯：";
            // 
            // cmbHometown
            // 
            this.cmbHometown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHometown.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbHometown.FormattingEnabled = true;
            this.cmbHometown.Items.AddRange(new object[] {
            "辽宁",
            "黑龙江",
            "长春",
            "北京",
            "上海",
            "湖南",
            "湖北",
            "内蒙古",
            "河北",
            "河南",
            "四川",
            "山东",
            "广东",
            "广西",
            "新疆",
            "西藏",
            "江苏",
            "浙江",
            "云南",
            "海南"});
            this.cmbHometown.Location = new System.Drawing.Point(112, 268);
            this.cmbHometown.Name = "cmbHometown";
            this.cmbHometown.Size = new System.Drawing.Size(178, 27);
            this.cmbHometown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(325, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "爱好：";
            // 
            // LstFavs
            // 
            this.LstFavs.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LstFavs.FormattingEnabled = true;
            this.LstFavs.ItemHeight = 19;
            this.LstFavs.Items.AddRange(new object[] {
            "音乐",
            "体育",
            "交友",
            "睡觉"});
            this.LstFavs.Location = new System.Drawing.Point(324, 74);
            this.LstFavs.Name = "LstFavs";
            this.LstFavs.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LstFavs.Size = new System.Drawing.Size(196, 194);
            this.LstFavs.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(43, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(348, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 341);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LstFavs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHometown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddStudent";
            this.Text = "FrmAddStudent";
            this.Load += new System.EventHandler(this.FrmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;

        public System.Windows.Forms.TextBox TxtName1
        {
            get { return TxtName; }
            set { TxtName = value; }
        }
        public System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rdofemale;
        public System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cmbHometown;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox LstFavs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}