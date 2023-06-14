using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba A1 = new Araba("Toyota","Auris");
            AraziArabasi A2=new AraziArabasi("Toyota","Hilux","4x4","Orta");
            BinekAraba B1 = new BinekAraba("Toyota", "Auris", "Dizel Motor", "Dizel");
            A1.yazdir();
            B1.yazdir();
            A2.yazdir(81);
            A2.yazdir();
            Console.ReadKey();
        }
    }
}
