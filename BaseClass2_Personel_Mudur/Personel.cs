using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass2_Personel_Mudur
{
    internal class Personel
    {
        private string AdSoyad;

        public string adsoyad 
        {
            get 
            {
                return AdSoyad;
            }
            set 
            {
                AdSoyad = value; 
            }
        }

        public int saat;
        public int maas;
        public int katsayi;
    }
}
