using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdaFonksyonKullanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hesap(9);
        }
        void yazdır()
        {
            txtbAd.Text = "kadir";
            txtbSoyad.Text = "kaya";
            txtbSehir.Text = "istanbul";
        }

        void temizle()
        {
            txtbAd.Text = " ";
            txtbSoyad.Text = " ";
            txtbSehir.Text = " ";
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            yazdır();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void hesapla()
        {
            int num1 = 7;
            int num2 = 8;
            int sonuc = num1 + num2;
            label5.Text = sonuc.ToString();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            hesapla();
        }

        void aktar()
        {
            for (int i = 1; i <= 10; i++)
            {
                lstbAktar.Items.Add(i);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            aktar();
        }
        void goster(string parameter)
        {
            for (int i = 1; i <=5; i++)
            {
                lstbAktar.Items.Add(parameter);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            goster("bilgisayar programcılığı");
        }
        void hesap(int sayi)
        {
            int s = sayi * sayi;
            label4.Text = s.ToString();
        }
    }
}
