using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                string yazi = txtYazi.Text;
                int num = Convert.ToInt32(yazi);
                int sonuc = num +=3;
                MessageBox.Show("sonuç : "+sonuc.ToString());

            }
            catch (FormatException ex)
            {

                MessageBox.Show("Bir değer girmelisiniz !" +ex.Message, "HATA !");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Üst sırını aştınız !"+ ex.Message, "HATA !");
            }
            finally
            {
                MessageBox.Show("Finnaly çalıştı");
            }    
        }
    }
}
