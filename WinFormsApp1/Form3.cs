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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] manisaIlce = { "Turgutlu", "Muradiye", "Kula" };
        string[] izmirIlce = { "Bornova", "Bayraklı", "Çambel" };
        string[] aydınIlce = { "Kusadası", "Incırlıova", "Kösk" };

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] dizi = { "Manisa", "İzmir", "Aydın", "İstanbul", "Ağrı" };
            comboBox1.Items.AddRange(dizi);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "Manisa")
                comboBox2.Items.AddRange(manisaIlce);
            if (comboBox1.Text == "İzmir")
                comboBox2.Items.AddRange(izmirIlce);
            if (comboBox1.Text == "Aydın")
                comboBox2.Items.AddRange(aydınIlce);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text + "/" + comboBox2.Text);
        }
    }
}
