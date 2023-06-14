using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class Turkce : Ders
    {
        public Turkce():base(5)
        {
            Console.WriteLine("Türkçe Sınıfı Parametresiz Yapıcı");
        }
        public Turkce(int deger)
        {
            Console.WriteLine("Türkçe Sınıfı Parametreli Ypıcı");
        }
    }
}
