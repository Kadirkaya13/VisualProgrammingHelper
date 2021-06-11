using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enBüyüğüBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBüyükBul_Click(object sender, EventArgs e)
        {
            int[] dizi = {1,3,8,41,56,78,52,45 };
            int enBuyuk = dizi[0];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i]>enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }
            label1.Text = enBuyuk.ToString();
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            int[] sayılar = { 1, 5, 8, 21, 45, 56, 85, 4 };
            Array.Sort(sayılar);

            foreach (var sayı in sayılar)
            {
                listBox1.Items.Add(sayı);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count>0)
            {
                listBox1.Items.Clear();
            }
            int[] sayılar = { 1, 5, 8, 21, 45, 56, 85, 4 };
            Array.Reverse(sayılar);

            foreach (var sayı in sayılar)
            {
                listBox1.Items.Add(sayı);
            }
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>=0)
            {
                MessageBox.Show(listBox1.SelectedItem.ToString());
                
            }
            else
            {
                MessageBox.Show("Seçim yapmadınız");
            }
        }
    }
}
