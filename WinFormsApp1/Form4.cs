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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int dakika = 0, sayac = 0, saat = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac < 60)
            {
                label6.Text = sayac.ToString();
            }
            else
            {
                sayac = 0;
                label6.Text = sayac.ToString();
                dakika++;
                if (dakika < 60)
                {
                    label3.Text = dakika.ToString();
                }
                else
                {
                    dakika = 0;
                    label3.Text = dakika.ToString();
                    saat++;
                    label1.Text = saat.ToString();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt16(comboBox1.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            dakika.Equals(0);
            sayac.Equals(0);    
            saat.Equals(0);
        }
    }
}
