﻿using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int number = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
                MessageBox.Show("Doğru Giriş Yapıldı..");
            else
            {
                DialogResult secenek = MessageBox.Show("Yanlış Giriş. Tekrar denemek istermisiniz",
                    "Bilgilendirme Penceresi", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (secenek == DialogResult.Yes)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else if (secenek == DialogResult.No)
                {
                    Form1.ActiveForm.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
