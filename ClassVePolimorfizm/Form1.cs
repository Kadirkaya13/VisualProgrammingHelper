using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassVePolimorfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Papağan papağan = new Papağan();
            papağan.tur = textBox1.Text;
            papağan.ayak = Convert.ToInt32( textBox2.Text);
            papağan.ses = textBox3.Text;
            papağan.renk = textBox4.Text;
            papağan.isim = textBox5.Text;

            listBox1.Items.Add(papağan.tur+papağan.ayak+papağan.ses+papağan.ses+papağan.renk+papağan.isim);
        }
    }
}
