using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FolderBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label2.Text = openFileDialog1.FileName;
        }
        string belgeyolu;
        string belgeadı;
        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                belgeyolu = folderBrowserDialog1.SelectedPath;
                textBox2.Text = belgeyolu;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
                belgeadı = textBox1.Text;
                StreamWriter sw = File.CreateText(belgeyolu+"\\"+belgeadı+".txt");
                MessageBox.Show("belge oluşturuldu");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satır = oku.ReadLine();
                while (satır!=null)
                {
                    listBox1.Items.Add(satır);
                    satır = oku.ReadLine();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyası|*.txt";
            saveFileDialog1.ShowDialog();
            StreamWriter kaydet = new StreamWriter(saveFileDialog1.FileName);
            kaydet.WriteLine(richTextBox1.Text);
            kaydet.Close();
            MessageBox.Show("kaydetme işlemi başarılı");
        }
    }
}
