using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innterface3
{
    internal class Mudur:IPersonel
    {
        private string Ad;
        private int Id;
        private double Maas;
        public string ad { get { return Ad; } set { Ad = value; } }
        public int id { get { return Id; } set { Id = value; } }
        public Mudur(string deger1, int deger2)
        {
            this.Ad = deger1;
            this.Id = deger2;
        }
        public double maas(int saat, int katsayi) 
        { 
            Maas= 8000+(saat*katsayi);
            return Maas;
        }
        public void goruntule() 
        {
            Console.WriteLine("Ad :" + ad);
            Console.WriteLine("Id :" + id);
            Console.WriteLine("Müdür maaşı :" + Maas); 
        }
    }
}
