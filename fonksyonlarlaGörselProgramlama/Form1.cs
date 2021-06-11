using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fonksyonlarlaGörselProgramlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kup(int sayi)
        {
            int sonuc = sayi * sayi * sayi;
            return sonuc;
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtbNum.TextLength>0)
            {
                 lblSonuc.Text = kup(Convert.ToInt32(txtbNum.Text)).ToString();
            }
           
        }
    }
}
