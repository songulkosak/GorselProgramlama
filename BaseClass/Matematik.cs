using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    internal class Matematik:Ders
    {
        public Matematik()
        {
            Console.WriteLine("Matematik Sınıfı Parametresiz Yapıcı");
        }
        public Matematik(int deger)
        {
            Console.WriteLine("Matematik Sınıfı Parametreli Ypıcı");
        }
    }
}
