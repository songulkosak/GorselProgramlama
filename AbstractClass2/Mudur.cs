using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    internal class Mudur:Personel
    {
        public Mudur(int deger):base(deger) 
        {
            Console.WriteLine("Müdür Sınıfı: ");
        }
        public override double maas(int katsayi)
        {
            return katsayi=450;
        }
    }
}
