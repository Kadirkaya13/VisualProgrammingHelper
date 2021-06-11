using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxFirstCountAfterWriteToListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sayi;
            for (int i = 0; i <= 10; i++)
            {
                sayi = Convert.ToInt32(Interaction.InputBox(i + ".sayıyı giriniz"));
                lstbListe.Items.Add(sayi);
            }
        }

        private void btnSırala_Click(object sender, EventArgs e)
        {
            for (int k = 0; k <= 9; k++)
            {
                for (int m = k+1; m <=9 ; m++)
                {
                    if (Int32.Parse(lstbListe.Items[k].ToString())>Int32.Parse(lstbListe.Items[m].ToString()))
                    {
                        int araDeğisken = Int32.Parse(lstbListe.Items[k].ToString());
                        lstbListe.Items[k] = lstbListe.Items[m];
                        lstbListe.Items[m] = lstbListe.Items[k];
                    }
                }
            }
        }
    }
}
