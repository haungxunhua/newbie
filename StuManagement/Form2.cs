﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                button1.Left += 10;
            }
            
        }
        protected override bool ProcessDialogChar(char charCode)
        {
            MessageBox.Show("FASDF");
            return false;
        }
        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            return false;
        }
    }
}
