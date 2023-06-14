using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    public class Kisi
    {
        public int yas;
        public string Ad, Soyad;
        public string Kimlik;

        public void degerata(int deger1,string deger2,string deger3,string deger4)
        {
            yas = deger1;
            Ad = deger2;
            Soyad = deger3;
            Kimlik = deger4;
        }
    }
}
