using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace murathocaudemy
{
    internal class skisisel
    {
        public string isim;
       public string SOYAD;
        public string bolum;

        public string İSİm
        {
            get { return isim; }
            set { isim = value.ToUpper(); }
        }
        public string SOYİSİM
        {
            get { return SOYAD; }
            set { SOYAD = value.ToUpper(); }
        }
        public string BOLUM
        {
            get { return bolum; }
            set { bolum = value.ToUpper(); }
        }





    }
}
