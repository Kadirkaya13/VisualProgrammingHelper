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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Ev ev = new Ev();
            ev.renk = "mavi";
            ev.kat = "5";
            ev.tur = 'd';
            ev.fiyat = 7850;
            label1.Text = "renk:" + ev.renk;
            label2.Text = "kat : " + ev.kat;
            label3.Text = "yakıt : " + ev.tur;
            label4.Text = "fiyat :" + ev.fiyat;
        }
        notlar not = new notlar();
        Student student = new Student();
        private void button2_Click(object sender, EventArgs e)
        {
            
            student.Adi = textBox1.Text;
            student.Soyad = textBox2.Text;
            student.Bolum = textBox3.Text;
           

            not.not1 = Convert.ToInt32(textBox4.Text);
            not.not2 = Convert.ToInt32(textBox5.Text);
            not.not3 = Convert.ToInt32(textBox6.Text);
            
            not.ortalama= (not.not1 + not.not2 + not.not3) / 3;

            listBox1.Items.Add(student.Adi + " "+student.Soyad + " " + student.Bolum+" ort :"+not.ortalama);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = ((not.not1 + not.not2 + not.not3) / 3).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Ad = textBox1.Text;
            form2.Soyad = textBox2.Text;
            form2.Bolum = textBox3.Text;
            form2.ShowDialog();
        }
    }
}
