using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fromLoad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Name = i+".button";
                button.Text = "load ile oluşan button";
                button.Location = new Point(50,i*50);
                button.Height = 50;
                button.Width = 100;
                this.Controls.Add(button);
            }
            
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Location = new Point(100,75);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 10;
            pictureBox1.Location = new Point(sayac, sayac);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeSpan zaman = dateTimePicker2.Value - dateTimePicker1.Value;
            int fark = zaman.Days;
            label3.Text = fark.ToString();
        }
    }
}
