using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuManagement
{
    public partial class Form1 : Form
    {
        private StudentMS sms = new StudentMS();
        private DataTable dt = new DataTable();



        public void DelStudent(int index)
        {
            try
            {
                sms.DelStudent(index);
                Refresh_GridView();
            }
            catch (IDErrorException e)
            {
                MessageBox.Show(e.Message);
            }
            

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            grid.Left = 0;
            grid.Top = menuStrip1.Height;
            grid.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - menuStrip1.Height);// this.ClientSize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("学号");
            dt.Columns.Add("姓名");
            dt.Columns.Add("年龄");
            dt.Columns.Add("性别");
            dt.Columns.Add("籍贯");
            dt.Columns.Add("爱好");
            grid.DataSource = dt;
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent frm = new FrmAddStudent();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                String name=frm.TxtName1.Text.Trim();
                int age=(int)frm.numAge.Value;
                string sex=frm.rdomale.Checked?"男":"女";
                string strHomeTown=frm.cmbHometown.Text.Trim();
                //string strFavs = null ;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i <frm.LstFavs.SelectedItems.Count; i++)
                {
                   sb.Append(frm.LstFavs.SelectedItems[i]);
                   if(i<frm.LstFavs.SelectedItems.Count-1)
                    sb.Append("|");
                }
                Student s = new Student(name, age, sex, strHomeTown, sb.ToString());
                this.sms.Add(s);
               
                Refresh_GridView();
            }
            else
            {

            }
        }
        private void Refresh_GridView()
        {
            dt.Clear();
            foreach (Student s in sms)
            {
                DataRow row = dt.NewRow();
                row[0] = s.Id;
                row[1] = s.Name;
                row[2] = s.Age;
                row[3] = s.Sex;
                row[4] = s.Hometown;
                row[5] = s.Favs;
                dt.Rows.Add(row);
            }
        }

        private void 删除学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // FrmDelStu frm = new FrmDelStu(this);
            FrmDelStu frm = new FrmDelStu();
            frm.Show();
            frm.Owner = this;
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
