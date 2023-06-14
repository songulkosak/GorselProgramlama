using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilikPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan H1= new Hayvan("Tekir","Miyav","Van");    
            Hayvan H2= new Hayvan("AAA","Vız vız","BBB");
            H1.yazdir();
            H2.yazdir();
            Console.ReadKey();
        }
    }
}
