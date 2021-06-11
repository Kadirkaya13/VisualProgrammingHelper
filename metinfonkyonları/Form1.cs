using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metinfonkyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = richTextBox1.Text;
            textBox2.Text = metin.StartsWith("merhaba").ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = richTextBox1.Text;
            textBox2.Text = metin.Trim().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin = richTextBox1.Text;
            textBox2.Text = metin.ToUpper().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = richTextBox1.Text;
            textBox2.Text = metin.Replace("?","*");
        }
    }
}
