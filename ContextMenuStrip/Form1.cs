using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapMakinasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac>=0&&sayac<=30)
            {
                BackColor = Color.Red;
            }
            else if(sayac>=31&&sayac<=40)
            {
                BackColor = Color.Yellow;
            }
            else if(sayac>=41&&sayac<=70)
            {
                BackColor = Color.Green;
            }
            else
            {
                sayac = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["bölgeler"].Points.AddXY("akdeniz", 21);
            chart1.Series["bölgeler"].Points.AddXY("kardeniz", 60);
            chart1.Series["bölgeler"].Points.AddXY("ege", 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value +=  10;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==progressBar1.Maximum)
            {
                progressBar1.Value = 1;
            }
            else
            {
                progressBar1.Value = progressBar1.Value +1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult pussed = colorDialog1.ShowDialog();
            if (pussed==DialogResult.OK)
            {
                BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult basım = folderBrowserDialog1.ShowDialog();
            if (basım==DialogResult.OK)
            {
                DirectoryInfo dosya = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] belgeler = dosya.GetFiles("*.docx");

                foreach (FileInfo item in belgeler)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult basılan = fontDialog1.ShowDialog();
            if (basılan==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
    }
}
