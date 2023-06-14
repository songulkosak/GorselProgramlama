using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilikPolymorphism
{
    internal class Arı:Hayvan
    {
        public Arı(string isim)
        {
            this.isim = isim;
            this.ses = "Vız vız";
            this.kimlik = "Arı";
        }
        public Arı(string isim,string kimlik)
        {
            this.isim = isim;
            this.ses = "Vız Vız";
            this.kimlik = kimlik;
        }
    }
}
