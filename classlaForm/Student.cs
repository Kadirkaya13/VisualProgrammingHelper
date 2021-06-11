using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlaForm
{
    public class Student
    {
        public string ad;
        private string soyad;
        private string bolum;

        public string Adi
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }

        public string Soyad { get => soyad; set => soyad = value; }
        public string Bolum { get => bolum; set => bolum = value; }
    }
}
