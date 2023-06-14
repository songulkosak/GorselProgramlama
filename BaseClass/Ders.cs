using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class Ders
    {
        public Ders() 
        {
            Console.WriteLine("Ders Sınıfı Parametresiz Yapıcı");
        }
        public Ders(int deger)
        {
            Console.WriteLine("Ders Sınıfı Parametreli Ypıcı");
        }
    }
}
