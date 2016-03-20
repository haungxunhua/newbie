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
    public partial class books : Form
    {  
       // DataTable dt2=new DataTable();
        DataTable dt = new DataTable();
        private Mnage_book mb = new Mnage_book();
       // private Mnage_Student ms = new Mnage_Student();
        public books()
        {
            InitializeComponent();
        }

        private void books_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Id");
            dt.Columns.Add("Author");
            dt.Columns.Add("Publish  Company");
            dt.Columns.Add("Publish  Time");
            dt.Columns.Add("Kind");
            dt.Columns.Add("Price");
            dt.Columns.Add("Amount");
            dataGridView1.DataSource = dt;
            this.dataGridView1.Left = 0;
            
            this.dataGridView1.Top = this.menuStrip1.Height;
            this.dataGridView1.Size = this.ClientSize;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         //   FilRead();
         //   Fresh();

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
            foreach (Book b in mb)
            {
                DataRow row = dt.NewRow();
                
                row[0] = b.Name;
                row[1] = b.Id;
                row[2] = b.Author;
                row[3] = b.Publish_company;
                row[4] = b.Publish_time;
                row[5] = b.Kind;
                row[6] = b.Price;
                row[7] = b.Book_number;
                dt.Rows.Add(row);

            }
        }

        private void FilSave()
        {
            try
            {
                string file = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Book.dat";
                //FileStream fs = new FileStream(@file, FileMode.Append, FileAccess.Write);
                //fs.Close();
                Stream stream = new FileStream(@file, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();   //创建序列化对象
                bf.Serialize(stream, mb);    //把学生列表序列化并写入流
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
                string file = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Book.dat";
                Stream stream = new FileStream(@file, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();    //创建序列化对象 
                mb = (Mnage_book)bf.Deserialize(stream); //把流反序列化            
                stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 增加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add frm_add = new Add();
            frm_add.Owner = this;
            if (frm_add.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Book b = new Book(frm_add.textBox1.Text.ToString(),
                        Convert.ToInt32(frm_add.textBox2.Text),
                        frm_add.textBox3.Text.ToString(),
                        frm_add.textBox4.Text.ToString(),
                      Convert.ToInt32(frm_add.textBox5.Text),

                        frm_add.checkedListBox1.SelectedItem.ToString(),
                        Convert.ToInt16(frm_add.textBox6.Text),
                      Convert.ToInt16(frm_add.textBox7.Text));
                    mb.Add(b);
                    FilSave();
                 //   count++;
                    // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                }
                catch (System.Exception)
                {
                    MessageBox.Show(" wrong login");
                }
                finally
                {

                    Fresh();
                }
            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilSave();
            MessageBox.Show("success!!!");
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilRead();
            Fresh();
        }

        private void 查询图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            if (sea.ShowDialog() == DialogResult.OK)
            {
                int id = Convert.ToInt32(sea.textBox1.Text);
                int index;
                if ((index = mb.Find(id)) != -1)
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

        private void 删除图书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete frm_del = new Delete();
            frm_del.Owner = this;
            if (frm_del.ShowDialog() == DialogResult.OK)
            {
                long index;
                index = Convert.ToInt32(frm_del.textBox1.Text);
                if (index < 0)
                    MessageBox.Show("Wrong Id");
                else
                {

                    this.mb.Del(index);
                    Fresh();
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 借阅人ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Show();
        }

        private void 清空图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            
        }
        
        private void 借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilRead();
            Book_Borrow bb = new Book_Borrow();
            bb.Owner = this;
             
            
            long index;
            
             if (bb.ShowDialog() == DialogResult.OK)
             {
                 index = Convert.ToInt32(bb.textBox1.Text);
                 foreach(Book b in mb)
                 {
                     if(b.Id==index)
                     {
                        
                         
                         b.Book_number--;
                         MessageBox.Show("   Success!!");
                     }
                     
                 }
                 
             }
             Fresh();
        }

     /*   private void 增加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 1;
            Add frm_add = new Add();
            frm_add.Owner = this;
            if (frm_add.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Book b = new Book( frm_add.textBox1.Text.ToString(),
                        Convert.ToInt32(frm_add.textBox2.Text),
                        frm_add.textBox3.Text.ToString(),
                        frm_add.textBox4.Text.ToString(),
                      Convert.ToInt32(frm_add.textBox5.Text),
                     
                        frm_add.checkedListBox1.SelectedItem.ToString(),
                        Convert.ToInt16(frm_add.textBox6.Text),
                      Convert.ToInt16(  frm_add.textBox7.Text));
                        mb.Add(b);
                        count++;
                       // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                }
                catch (System.Exception )
                {
                    MessageBox.Show(" wrong login");
                }
                finally
                {
                   
                   Fresh();
                }
            }
        }

      /*  private void 查询图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search sea = new Search();
            if(sea.ShowDialog()==DialogResult.OK)
            {
                int id = Convert.ToInt32(sea.textBox1.Text);
                int index;
                if ((index = mb.Find(id)) != -1)
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
        */
        /*private void 删除图书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete frm_del = new Delete();
            frm_del.Owner = this;
            if (frm_del.ShowDialog() == DialogResult.OK)
            {
                long index;
                index = Convert.ToInt32(frm_del.textBox1.Text);
                if (index < 0)
                    MessageBox.Show("Wrong Id");
                else
                {

                    this.mb.Del(index);
                    Fresh();
                }
            }

        }
        
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"D:\Documents\Visual Studio 2013\Projects\library\library\bin\Debug\student_obj.dat";
            Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, mb);
            stream.Close();
            MessageBox.Show("      Success!!!");
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"D:\Documents\Visual Studio 2013\Projects\library\library\bin\Debug\student_obj.dat";
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Mnage_book bm = (Mnage_book)bf.Deserialize(stream);
            dt.Rows.Clear();
            foreach (Book b in bm)
            {
                DataRow row = dt.NewRow();

                row[0] = b.Name;
                row[1] = b.Id;
                row[2] = b.Author;
                row[3] = b.Publish_company;
                row[4] = b.Publish_time;
                row[5] = b.Kind;
                row[6] = b.Price;
                row[7] = b.Book_number;
                dt.Rows.Add(row);
                

            }
            stream.Close();
        }

        private void 借阅人ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Show();
        }

        private void 删除图书ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string file = @"D:\Documents\Visual Studio 2013\Projects\library\library\bin\Debug\student_obj.dat";
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Mnage_book bm = (Mnage_book)bf.Deserialize(stream);
          
            
            Delete frm_del = new Delete();
            frm_del.Owner = this;
            if (frm_del.ShowDialog() == DialogResult.OK)
            {
                long index;
                index = Convert.ToInt32(frm_del.textBox1.Text);
                if (index < 0)
                    MessageBox.Show("Wrong Id");
                else
                {

                    bm.Del(index);
                   // Fresh();
                }
            }
          dt.Rows.Clear();
            foreach (Book b in bm)
            {
                DataRow row = dt.NewRow();

                row[0] = b.Name;
                row[1] = b.Id;
                row[2] = b.Author;
                row[3] = b.Publish_company;
                row[4] = b.Publish_time;
                row[5] = b.Kind;
                row[6] = b.Price;
                row[7] = b.Book_number;
                dt.Rows.Add(row);


            }
            stream.Close();
        }

        private void 查询图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"D:\Documents\Visual Studio 2013\Projects\library\library\bin\Debug\student_obj.dat";
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Mnage_book bm = (Mnage_book)bf.Deserialize(stream);
            dt.Rows.Clear();

            
            foreach (Book b in bm)
            {
                DataRow row = dt.NewRow();

                row[0] = b.Name;
                row[1] = b.Id;
                row[2] = b.Author;
                row[3] = b.Publish_company;
                row[4] = b.Publish_time;
                row[5] = b.Kind;
                row[6] = b.Price;
                row[7] = b.Book_number;
                dt.Rows.Add(row);


            }
            stream.Close();
            Search sea = new Search();
            if (sea.ShowDialog() == DialogResult.OK)
            {
                int id = Convert.ToInt32(sea.textBox1.Text);
                int index;
                if ((index = bm.Find(id)) != -1)
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

      /*  private void 增加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file = @"D:\Documents\Visual Studio 2013\Projects\library\library\bin\Debug\student_obj.dat";
            Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Mnage_book bm = (Mnage_book)bf.Deserialize(stream);
            dt.Rows.Clear();
         /*   foreach (Book b in bm)
            {
                DataRow row = dt.NewRow();

                row[0] = b.Name;
                row[1] = b.Id;
                row[2] = b.Author;
                row[3] = b.Publish_company;
                row[4] = b.Publish_time;
                row[5] = b.Kind;
                row[6] = b.Price;
                row[7] = b.Book_number;
                dt.Rows.Add(row);


            }
           
            int count = 1;
            Add frm_add = new Add();
            frm_add.Owner = this;
            if (frm_add.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Book b = new Book(frm_add.textBox1.Text.ToString(),
                        Convert.ToInt32(frm_add.textBox2.Text),
                        frm_add.textBox3.Text.ToString(),
                        frm_add.textBox4.Text.ToString(),
                      Convert.ToInt32(frm_add.textBox5.Text),

                        frm_add.checkedListBox1.SelectedItem.ToString(),
                        Convert.ToInt16(frm_add.textBox6.Text),
                      Convert.ToInt16(frm_add.textBox7.Text));
                    bm.Add(b);
                    count++;
                    // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                }
                catch (System.Exception)
                {
                    MessageBox.Show(" wrong login");
                }
                finally
                {

                    foreach (Book b in bm)
                    {
                        DataRow row = dt.NewRow();

                        row[0] = b.Name;
                        row[1] = b.Id;
                        row[2] = b.Author;
                        row[3] = b.Publish_company;
                        row[4] = b.Publish_time;
                        row[5] = b.Kind;
                        row[6] = b.Price;
                        row[7] = b.Book_number;
                        dt.Rows.Add(row);


                    }

                   // Fresh();
                }
            }
            stream.Close();
        }

        private void 初始化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 1;
            Add frm_add = new Add();
            frm_add.Owner = this;
            if (frm_add.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Book b = new Book(frm_add.textBox1.Text.ToString(),
                        Convert.ToInt32(frm_add.textBox2.Text),
                        frm_add.textBox3.Text.ToString(),
                        frm_add.textBox4.Text.ToString(),
                      Convert.ToInt32(frm_add.textBox5.Text),

                        frm_add.checkedListBox1.SelectedItem.ToString(),
                        Convert.ToInt16(frm_add.textBox6.Text),
                      Convert.ToInt16(frm_add.textBox7.Text));
                    mb.Add(b);
                    count++;
                    // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                }
                catch (System.Exception)
                {
                    MessageBox.Show(" wrong login");
                }
                finally
                {

                    Fresh();
                }
            }
            
        }

        private void 增加图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int count = 1;
            Add frm_add = new Add();
            frm_add.Owner = this;
            if (frm_add.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Book b = new Book(frm_add.textBox1.Text.ToString(),
                        Convert.ToInt32(frm_add.textBox2.Text),
                        frm_add.textBox3.Text.ToString(),
                        frm_add.textBox4.Text.ToString(),
                      Convert.ToInt32(frm_add.textBox5.Text),

                        frm_add.checkedListBox1.SelectedItem.ToString(),
                        Convert.ToInt16(frm_add.textBox6.Text),
                      Convert.ToInt16(frm_add.textBox7.Text));
                    mb.Add(b);
                    count++;
                    // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                }
                catch (System.Exception)
                {
                    MessageBox.Show(" wrong login");
                }
                finally
                {

                    Fresh();
                }
            }
            

        }

      

       

      
        

       private void 增加借阅人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  int count = 1;
            Add_Student ad = new Add_Student();
            ad.Owner = this;
            if (ad.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Student s = new Student(Convert.ToInt32(ad.textBox5.Text), 0, 
                        ad.textBox1.ToString(),
                        ad.radioButton1.Checked ? "male" : "female",
                        Convert.ToInt32(ad.textBox3.Text),
                        ad.textBox4.Text.ToString());
                  //  count++;
                    // DataGridViewRow dv = dataGridView1.Rows[count] as DataGridViewRow;
                }
                catch (System.Exception)
                {
                    MessageBox.Show("   wrong login!!1");
                }
                finally
                {

                    Fresh1();
                }
            }

        }

       

       
        
        
      */

      
    }
}
