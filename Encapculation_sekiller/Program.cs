using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapculation_sekiller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen D1 = new Dikdörtgen(34,67);
            //D1.setgenislik(34);
            //D1.setyukseklik(67);
            Console.WriteLine("Alan :" + D1.alanHesabi());
            Console.Read();
        }
    }
}
