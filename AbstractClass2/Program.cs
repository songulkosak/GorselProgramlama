using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mudur M1=new Mudur(34);
            Sef S1=new Sef(44);
            Isci I1=new Isci(54);

            Console.WriteLine("Müdür Kimlik:"+M1.getkimlik());
            Console.WriteLine("Şef Kimlik:" + S1.getkimlik());
            Console.WriteLine("İşçi Kimlik:" + I1.getkimlik());

            Console.ReadKey();
        }
    }
}
