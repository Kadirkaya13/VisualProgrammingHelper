using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void getir()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(100,1000);
            label1.Text = sayi.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] harf = {"a","b","c","d" };
            int sayi = rand.Next(0, harf.Length);
            label1.Text= harf[sayi];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            double sonuc = (Math.Abs(sayi));
            textBox2.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            double sonuc = (Math.Sqrt(sayi));
            textBox2.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            double sonuc = (Math.Pow(sayi,2));
            textBox2.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            double sonuc = (Math.Sin(sayi));
            textBox2.Text = sonuc.ToString();
        }
    }
}
