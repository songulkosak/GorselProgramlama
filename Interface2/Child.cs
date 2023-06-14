using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal class Child:IFather,IMother
    {
        public void boyuzun() { Console.WriteLine("Boy uzunluğu"); }
        public void ses() { Console.WriteLine("Ses"); }
        public void gozrengi() { Console.WriteLine("Göz rengi"); }
        public void calisma() { Console.WriteLine("Çalışma"); }
    }
}
