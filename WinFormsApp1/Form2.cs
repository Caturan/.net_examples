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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int midterm = Convert.ToInt16(textBox1.Text);
            int final = Convert.ToInt16(textBox2.Text);
            double mean = (0.4 * midterm) + (0.6 * final);
            textBox3.Text = mean.ToString();
            if (mean < 50)
                MessageBox.Show("Failed");
            else
                MessageBox.Show("Success");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
