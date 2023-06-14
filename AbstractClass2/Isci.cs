using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    internal class Isci : Personel
    {
        public Isci(int deger) : base(deger)
        {
            Console.WriteLine("İşçi Sınıfı: ");
        }
        public override double maas(int katsayi)
        {
            return katsayi = 250;
        }
    }
}
