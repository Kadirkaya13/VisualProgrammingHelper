using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erişimBelirleyiciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int faktoriyel(int sayi)
        {
            if (sayi==0)
            {
                return 1;
            }
            return sayi * faktoriyel(sayi - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = faktoriyel(Convert.ToInt32(textBox1.Text)).ToString();
        }
        int ortalama(int s1,int s2,int s3)
        {
            int ortalama = (s1 + s2 + s3)/3;
            return ortalama;
        }
        int ortalama(int s1, int s2)
        {
            int ortalama = (s1 + s2) / 2;
            return ortalama;
        }

        private void btnort_Click(object sender, EventArgs e)
        {
            label2.Text= ortalama(75,56,48).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = ortalama(75, 48).ToString();
        }
    }
}
