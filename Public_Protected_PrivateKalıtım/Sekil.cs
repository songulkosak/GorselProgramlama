using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_protected_private_kalıtım
{
    internal class Sekil
    {
        public double alanHesabi(int deger1,int deger2,int deger3) 
        {
            return 2*(deger1 * deger2+deger1*deger3+deger2*deger3);
        }
        public double hacimHesabi(int deger1, int deger2,int deger3)
        {
            return deger1 * deger2*deger3;
        }
    }
}
