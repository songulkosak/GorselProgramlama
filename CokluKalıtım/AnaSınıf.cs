using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluKalıtım
{
    internal class AnaSınıf
    {
        public int degerA;
        public int degerB;
        public AnaSınıf()
        {
            Console.WriteLine("A-Parametresiz Yapıcı");
        }
        public AnaSınıf(int deger1,int deger2)
        {
            degerA=deger1;//24
            degerB = deger2;//34
            Console.WriteLine("A-Parametreli Yapıcı");
        }
    }
}
