using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Deşifre_Click(object sender, EventArgs e)
        {
            string metindesifre = textBox2.Text;
            byte[] verimetindesifre = Convert.FromBase64String(metindesifre);
            string anametin = Encoding.UTF8.GetString(verimetindesifre);
            textBox1.Text = anametin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttuon1_Click(object sender, EventArgs e)
        {
            string duzmetin = textBox1.Text;
            byte[] veridizileri = Encoding.UTF8.GetBytes(duzmetin);
            string sifrelimetin = Convert.ToBase64String(veridizileri);
            textBox2.Text = sifrelimetin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
