using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child C1=new Child();
            C1.boyuzun();
            C1.gozrengi();
            C1.calisma();
            C1.ses();
            Console.ReadKey();
        }
    }
}
