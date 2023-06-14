using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokluKalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TorunSınıf T1=new TorunSınıf();
            //TorunSınıf T2 = new TorunSınıf(34, 44, 54);

            CocukSınıf C1 = new CocukSınıf(24,34,44,54);
            Console.WriteLine(C1.degerA+"-"+ C1.degerB + "-" + C1.degerC + "-" + C1.degerD + "-" );
            Console.Read();
        }
    }
}
