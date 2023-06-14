using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluKalıtım
{
    internal class CocukSınıf:AnaSınıf
    {
        public int degerD;
        public int degerC;

        public CocukSınıf(int deger1,int deger2,int deger3,int deger4):base(deger1,deger2)
        {
            degerC = deger3;//44
            degerD = deger4;//54
            Console.WriteLine("B-Parametreli Yapıcı");
        }
    }
}
