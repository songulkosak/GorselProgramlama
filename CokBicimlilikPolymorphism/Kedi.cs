using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilikPolymorphism
{
    internal class Kedi:Hayvan
    {

        public Kedi(string isim)
        {
            this.isim = isim;
            this.ses = "Miyav ";
            this.kimlik ="Kedi";
        }
        public Kedi(string isim, string kimlik)
        {
            this.isim=isim;
            this.ses="Miyav";
            this.kimlik = kimlik;
        }
    }
}
