using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int sayac=3;
        private void Giriş_Click(object sender, EventArgs e)
        {
            string kullanıcı = "kadir";
            string sifre = "12345";
            if (textBox1.Text==kullanıcı&&textBox2.Text==sifre)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                sayac--;
                MessageBox.Show("Kullanıcı bilgilerinizi kontrol ediniz kalan hakkınız :"+sayac);
            }

            if (sayac==0)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
