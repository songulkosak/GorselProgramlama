using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal abstract class Canli
    {
        public abstract void ses();
        public abstract void hareket();
        public abstract void goruntu();
        public void ortakozellik()
        {
            Console.WriteLine("Hayvanların ortal özelliği");
        }
    }
}
