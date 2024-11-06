using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "123")
            {
                timer1.Enabled = false;
                label3.Text = "Entry Success";
                textBox1.Enabled = false;   
                textBox2.Enabled = false;
                label4.Visible = false;
            }
            else
            {
                MessageBox.Show("Wrong ID or password..");
            }
        }
        int kalansure = 120;
        private void timer1_Tick(object sender, EventArgs e)
        {
            kalansure--;
            label4.Text = kalansure.ToString();
            if (kalansure == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                label4.Text = "Time is done..";
                textBox1 .Enabled = false;
                textBox2.Enabled=false;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
