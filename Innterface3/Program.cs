using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innterface3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mudur M1=new Mudur("Ahmet Yılmaz",5000);
            Isci I1 = new Isci("Ender Doğan",2514);
            M1.maas(40, 40);
            M1.goruntule();
            I1.maas(60,30);
            I1.goruntule();
            Console.ReadKey();
        }
    }
}
