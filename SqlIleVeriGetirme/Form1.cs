using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlIleVeriGetirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=GoruntuIsleme; Integrated security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void listele()
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Kitaplar", SqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
