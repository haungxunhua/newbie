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
    public partial class FrmDelStu : Form
    {
       // Form1 frmMain= null;
        public FrmDelStu()
        {
         
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.delsms(IndexOutOfRangeException);
            //frmMain.DelStudent((int)numID.Value);
            Form1 frmMain = this.Owner as Form1;
            frmMain.DelStudent((int)numID.Value);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmDelStu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
