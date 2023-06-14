using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_protected_private_kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prizma P1 = new Prizma(24,34,44);
            Console.WriteLine("Alan :"+ P1.alanHesabi(P1.Boyut1, P1.Boyut2, P1.Boyut3));
            Console.WriteLine("Hacim :"+ P1.hacimHesabi(P1.Boyut1, P1.Boyut2, P1.Boyut3)); 

            Console.ReadKey();
        }
    }
}
