using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classlaForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Ad;
            label2.Text = Soyad;
            label3.Text = Bolum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = label1.Text;
            string soyad = label2.Text;
            string bolum =label3.Text;
            Form1 form1 = new Form1();
            listBox1.Items.Add(ad + " " + soyad + " " + bolum + " ort :");
        }
    }
}
