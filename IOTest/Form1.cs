using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IOTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // textBox1.Text = File.ReadAllText(@"d:\poet.txt", Encoding.Default);
            //FileStream fs = new FileStream(@"");
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName,FileMode.OpenOrCreate,FileAccess.Read);
             
                byte[] bData=new byte[fs.Length];
                fs.Read(bData, 0, (int)fs.Length);
                Decoder dc = Encoding.Default.GetDecoder();
                int cLength=dc.GetCharCount(bData,0,(int)fs.Length);
                char[] cData=new char[cLength];
                dc.GetChars(bData, 0, (int)fs.Length, cData, 0);
                textBox1.Text = new String(cData);
                fs.Close();



            
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ///File.WriteAllText(@"d:\poet.txt",textBox1.Text.Trim() ,Encoding.Default);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                char[] cData = new char[textBox1.Text.Trim().Length];
                Encoder ec = Encoding.Default.GetEncoder();
                cData = textBox1.Text.Trim().ToArray();
                int bLength = ec.GetByteCount(cData, 0, textBox1.Text.Trim().Length, true);
               
                byte[] bData = new byte[bLength];
                ec.GetBytes(cData, 0, textBox1.Text.Trim().Length, bData, 0, true);
                fs.Write(bData, 0, bLength);
                         
                fs.Close();




            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
