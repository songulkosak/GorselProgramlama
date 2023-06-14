using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Hayvan:Canli
    {
        public override void ses() { Console.WriteLine("SES"); }
        public  override void hareket() { Console.WriteLine("HAREKET"); }
        public override void goruntu() { Console.WriteLine("GÖRÜNTÜ"); }
    }
}
