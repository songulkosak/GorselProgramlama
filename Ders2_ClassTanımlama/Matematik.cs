using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetot
{
    internal class Matematik
    {
        public int sayi1, sayi2;
        public Matematik() 
        {
            Console.WriteLine("Parametresiz yapıcı metot çalıştı");
        }
        public Matematik(int deger1,int deger2)
        {
            Console.WriteLine("Parametreli yapıcı metot çalıştı");
            sayi1 = deger1;
            sayi2 = deger2; 
        }
    }
}
