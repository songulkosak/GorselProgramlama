using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapculation_sekiller
{
    internal class Dikdörtgen :Sekil
    {
        public int alanHesabi()
        {
            return genislik*yukseklik;
        }


        //ilk deger atamasını yapmak için sekil isimli Constucter oluşturuldu
        public Dikdörtgen(int deger1, int deger2)
        {
            genislik = deger1;
            yukseklik = deger2;
        }
    }
}
