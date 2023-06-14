using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilik2
{
    internal class Araba
    {
        public string Marka, Model;
        public Araba(string marka,string model)
        {
            this.Marka = marka;
            this.Model = model;
           
        }
        public void yazdir()
        {
            Console.WriteLine("Marka :" + Marka + "Model :" + Model);
        }
    }
}
