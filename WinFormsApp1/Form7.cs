﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
                if (i <= 30)
                { 
                    i += 1;
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);
                }
                if (i % 4 == 0)
                {
                    listBox3.Items.Add(i);
                }
                label2.Text = i.ToString();
                }
            else
            {
                Form7.ActiveForm.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
