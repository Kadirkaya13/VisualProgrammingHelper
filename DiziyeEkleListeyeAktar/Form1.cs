using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziyeEkleListeyeAktar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] sehirler = new string[5];
        int sayac = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbSehir.TextLength>=3)
            {
                sehirler[sayac] = txtbSehir.Text;
                sayac++;
                txtbSehir.Clear();
            }
            if (sayac==5)
            {
                MessageBox.Show("yeterli şehir yazıldı");
                txtbSehir.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (sayac==5)
            {
                foreach (var sehir in sehirler)
                {
                    lstbxListe.Items.Add(sehir);
                }
            }
            else
            {
                MessageBox.Show("az şehir girdiniz");
            }
            
        }
    }
}
