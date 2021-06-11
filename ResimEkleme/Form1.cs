using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResimEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.OpenFile());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "dosya seç";
            openFileDialog1.Filter = "jpeg dosyaları(*.jpeg)|*.jpg|bmp dosyaları( *.bmp)|*.bmp|gif dosyaları(*.gif)|*.gif";
            openFileDialog1.Title = "bir resim dosyası seçiniz";
            //başlangıç dosyasını belirler
            openFileDialog1.InitialDirectory = @"C:\Users\dell\Downloads\GoruntuIslemeProje\GoruntuIslemeProje\Images";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                MessageBox.Show("kelime sayısı ="+textBox1.Text.Split(' ').Length.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte i;
            string[] yazi = textBox1.Text.Split(' ');
            for ( i = 0; i < yazi.Length; i++)
            {
                listBox1.Items.Add(yazi[i].ToString());
            }

        }
    }
}
