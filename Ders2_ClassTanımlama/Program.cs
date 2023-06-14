using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YapiciMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M1=new Matematik();
            Matematik M2 = new Matematik(14,54);
            Console.ReadKey();
        }
    }
}
