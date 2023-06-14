using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass2_Personel_Mudur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1= new Personel();
            Mudur M1 = new Mudur();
            Memur M2 = new Memur();
            M1.maas = 5000 * M1.katsayi;
            M2.maas = 5000 * M2.katsayi;
            Console.WriteLine("Müdür maaşı :"+M1.maas);
            Console.WriteLine("Memur maaşı :"+M2.maas);
            M1.adsoyad = "mehmet";
            Console.Read();
        }
    }
}
