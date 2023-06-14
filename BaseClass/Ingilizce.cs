using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class Ingilizce : Ders
    {
        public Ingilizce()
        {
            Console.WriteLine("İngilizce Sınıfı Parametresiz Yapıcı");
        }
        public Ingilizce(int deger)
        {
            Console.WriteLine("İngilizce Sınıfı Parametreli Ypıcı");
        }
    }
}
