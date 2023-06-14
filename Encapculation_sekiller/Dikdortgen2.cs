using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapculation_sekiller
{
    internal class Dikdortgen2:Sekil
    {
        public Dikdortgen2(int deger1,int deger2)
        {
            genislik = deger1;
            yukseklik = deger2;

        }
        public int alanHesabi()
        {
            return yukseklik*genislik;
        }
    }
}
