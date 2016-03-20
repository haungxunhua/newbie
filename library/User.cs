using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace library
{
    public partial class User : Form
    {
        DataTable dt = new DataTable();
        private Mnage_Student ms = new Mnage_Student();

        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("Id");
            dt.Columns.Add("Book_Number");
            dt.Columns.Add("Name");
            dt.Columns.Add("Sex");
            dt.Columns.Add("Birth");
            dt.Columns.Add("Job_Unit");
         //   dt.Columns.Add("Price");
            dataGridView1.DataSource = dt;
            this.dataGridView1.Left = 0;
            
            this.dataGridView1.Top = this.menuStrip1.Height;
            this.dataGridView1.Size = this.ClientSize;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 

        }
       
         private void Form1_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Left = 0;
         
            this.dataGridView1.Top = this.menuStrip1.Height;
            this.dataGridView1.Size = this.ClientSize;
        }

         private void Fresh()
         {
             dt.Rows.Clear();
             foreach (Student b in ms)
             {
                 DataRow row = dt.NewRow();

                 row[0] = b.Id;
                 row[1] = b.Book_number;
                 row[2] = b.Name;
                 row[3] = b.Sex;
                 row[4] = b.Birth;
                 row[5] = b.Job_unit;
                // row[6] = b.Price;
                 dt.Rows.Add(row);

             }
         }
         private void FilSave()
         {
             try
             {
                 string file = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Student.dat";
                 //FileStream fs = new FileStream(@file, FileMode.Append, FileAccess.Write);
                 //fs.Close();
                 Stream stream = new FileStream(@file, FileMode.OpenOrCreate, FileAccess.Write);
                 BinaryFormatter bf = new BinaryFormatter();   //创建序列化对象
                 bf.Serialize(stream, ms);    //把学生列表序列化并写入流
                 stream.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }
         private void FilRead()
         {
             try
             {
                 string file = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Student.dat";
                 Stream stream = new FileStream(@file, FileMode.Open, FileAccess.Read);
                 BinaryFormatter bf = new BinaryFormatter();    //创建序列化对象 
                 ms = (Mnage_Student)bf.Deserialize(stream); //把流反序列化            
                 stream.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         }


         private void 增加借阅人ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             
             Add_Student ad = new Add_Student();
             ad.Owner = this;
             if (ad.ShowDialog() == DialogResult.OK)
             {
                 try
                 {
                     Student s = new Student(Convert.ToInt32(ad.textBox5.Text), 0,
                         ad.textBox1.Text.ToString(),
                         ad.radioButton1.Checked ? "male" : "female",
                         Convert.ToInt32(ad.textBox3.Text),
                         ad.textBox4.Text.ToString());
                     ms.Add(s);
                     FilSave();
                     //  count++;
                     // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                 }
                 catch (System.Exception)
                 {
                     MessageBox.Show("   wrong login!!");
                 }
                 finally
                 {
                    

                    Fresh();
                 }
             }
           
         }

         private void 查找借阅人ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             Search_Stu sea1 = new Search_Stu();
             if (sea1.ShowDialog() == DialogResult.OK)
             {
                 int id = Convert.ToInt32(sea1.textBox1.Text);
                 int index;
                 if ((index = ms.Find(id)) != -1)
                 {
                     DataGridViewRow dv = dataGridView1.Rows[index] as DataGridViewRow;
                     dv.Selected = true;
                 }
                 else
                 {
                     MessageBox.Show("Nothing!");
                 }

             }
         }

         private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
         {
            FilSave();
            MessageBox.Show("   Success!!!");
         }

         private void 读取ToolStripMenuItem_Click(object sender, EventArgs e)
         {
             FilRead();
             Fresh();
         }

        
    }
}
