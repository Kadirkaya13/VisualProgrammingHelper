using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlamaFinalÇalışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCellNum_Click(object sender, EventArgs e)
        {
            int bakteri = 1;
            for (int i = 0; i < 24; i++)
            {
                bakteri = bakteri * 2;
            }
            MessageBox.Show(bakteri.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 1;
            int toplam = 0;
            while (sayac<=10)
            {
                toplam += sayac;
                sayac++;
            }
            MessageBox.Show(toplam.ToString());
        }
    }
}
