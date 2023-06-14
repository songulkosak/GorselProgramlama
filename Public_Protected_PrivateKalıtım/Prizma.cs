using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_protected_private_kalıtım
{
    internal class Prizma:Sekil
    {
        protected int boyut1,boyut2,boyut3;
        public Prizma(int deger1,int deger2,int deger3)
        {
            boyut1 = deger1;
            boyut2 = deger2;
            boyut3 = deger3;
        }
        public int Boyut1 { get { return boyut1; } set {  boyut1 = value; } }
        public int Boyut2 { get { return boyut2; } set { boyut2 = value; } }
        public int Boyut3 { get { return boyut3; } set { boyut3 = value; } }
    }
}
