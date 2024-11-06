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
    public partial class Form5 : Form
    {
        int sayi = 60;
        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi > 0)
            {
                sayi--;
                label1.Text = sayi.ToString();
                if (sayi % 3 == 0)
                    label1.ForeColor = Color.Red;
                else if (sayi % 3 == 1)
                    label1.ForeColor = Color.Black;
                else
                    label1.ForeColor = Color.White;
            }
            else
                sayi = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
