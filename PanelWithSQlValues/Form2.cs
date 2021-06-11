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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;
        void notlar() {
            SqlCommand cmd = new SqlCommand("select OgrenciAdi,OgrenciSoyadi,AraSinav,Final,Ortalama from Notlar inner join Ogrenciler on Ogrenciler.OgrenciNo=Notlar.OgrenciNo", sqlBaglantisi.baglanti());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = kullaniciAdi;
            notlar();
        }
        void ekle()
        {

            SqlCommand komut = new SqlCommand("insert into Ogrenciler(OgrenciAdi,OgrenciSoyadi) values(@p1,@p2)",sqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2",textBox2.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci kaydı tamamlandı");
            sqlBaglantisi.baglanti().Close();
        }
        SqlBaglantisi sqlBaglantisi = new SqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }
        void listele()
        {
            SqlCommand sqlCommand = new SqlCommand("select * from ogrenciler",sqlBaglantisi.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt =new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            label5.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }
        void guncelle()
        {
            SqlCommand sqlCommand = new SqlCommand("update Ogrenciler set OgrenciAdi=@p1,OgrenciSoyadi=@p2 where OgrenciNo=@p3",sqlBaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", textBox1.Text);
            sqlCommand.Parameters.AddWithValue("@p2", textBox2.Text);
            sqlCommand.Parameters.AddWithValue("@p3", label5.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Güncelleme gerçekleşti");
            sqlBaglantisi.baglanti().Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int arasinav = Convert.ToInt32(textBox3.Text);
            int final = Convert.ToInt32(textBox4.Text);
            int ortalama = (arasinav %40) + (final %60) ;
            textBox5.Text = ortalama.ToString();

        }
        void sil()
        {
           
                SqlCommand sqlCommand = new SqlCommand("Delete from Ogrenciler where OgrenciNo=@p1",sqlBaglantisi.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", label5.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Silme gerçekleşti");
                sqlBaglantisi.baglanti().Close();
            
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            sil();
        }
        void notEkle()
        {
            if (label5.Text != null)
            {
                SqlCommand komut = new SqlCommand("insert into Notlar(OgrenciNo,Arasinav,Final,Ortalama,DersKodu) values(@p1,@p2,@p3,@p4,@p5)", sqlBaglantisi.baglanti());
                komut.Parameters.AddWithValue("@p1", label5.Text);
                komut.Parameters.AddWithValue("@p2", textBox3.Text);
                komut.Parameters.AddWithValue("@p3", textBox4.Text);
                komut.Parameters.AddWithValue("@p4", textBox5.Text);
                komut.Parameters.AddWithValue("@p5", textBox6.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Öğrenci kaydı tamamlandı");
                sqlBaglantisi.baglanti().Close();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
                notEkle();
            
            
        }
    }
}
