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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = textBox1.Text;
            char Harf = Convert.ToChar(textBox2.Text);
            int harfsayisi = 0;
            foreach (char c in cumle)
            {
                if (Harf == c)
                {
                    harfsayisi++;
                }
            }
             MessageBox.Show(Harf.ToString() + " Harfinin toplam sayisi: " + harfsayisi.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
