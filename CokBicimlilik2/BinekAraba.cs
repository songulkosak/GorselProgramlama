using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik2
{
    internal class BinekAraba:Araba
    {
        public string Motorbilgi, Yakitturu;
        public BinekAraba(string marka,string model,string motorbilgi,string yakitturu) : base(marka, model)
        {
            this.Motorbilgi = motorbilgi;
            this.Yakitturu= yakitturu;
        }
        public void yazdir()
        {
            Console.WriteLine("Marka :" + Marka + "Model :" + Model+"Motor Bilgi :" + Motorbilgi + "Yakıt Türü :" + Yakitturu);
        }
    }
}
