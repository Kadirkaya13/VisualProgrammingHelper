using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraylerdekullanılanfonksyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayılar = { 1, 2, 5, 6, 3, 45, 625, 48, 75, 5, 9 };
        private void btnIndex_Click(object sender, EventArgs e)
        {
            int sira;
            sira =Array.IndexOf(sayılar, 48);
            label1.Text = sira.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            label1.Text = sayılar.Max().ToString();
        }
    }
}
