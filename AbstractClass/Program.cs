using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan H1=new Hayvan();
            H1.goruntu();
            H1.hareket();
            H1.ses();
            H1.ortakozellik();

            Console.ReadKey();
        }
    }
}
