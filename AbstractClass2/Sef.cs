using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    internal class Sef:Personel
    {
        public Sef(int deger) : base(deger)
        {
            Console.WriteLine("Şef Sınıfı: ");
        }
        public override double maas(int katsayi)
        {
            return katsayi = 300;
        }
    }
}
