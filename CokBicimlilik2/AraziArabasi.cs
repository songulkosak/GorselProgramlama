using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik2
{
    internal class AraziArabasi:Araba
    {
        public string Cekisgucu,Yukseklik;
        public AraziArabasi(string marka,string model,string cekisgucu,string yukseklik):base(marka,model)
        {
            this.Cekisgucu = cekisgucu;
            this.Yukseklik = yukseklik;
        }
        public void yazdir(int sayi)
        {
            Console.WriteLine("Marka :" + Marka + "Model :" + Model+"Çekiş Gücü :" + Cekisgucu+"Yükseklik :"+Yukseklik);
        }
        public void yazdir()
        {
            Console.WriteLine("Marka :" + Marka + "Model :" + Model);
        }
    }
}
