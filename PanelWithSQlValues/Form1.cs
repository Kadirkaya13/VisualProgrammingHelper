using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PanelWithSQlValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from Kullanicilar where KullaniciAdi=@p1 and sifre=@p2",sqlBaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@p2",textBox2.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                Form2 frm = new Form2();
                frm.kullaniciAdi = textBox1.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            sqlBaglantisi.baglanti().Close();
        }
    }
}
