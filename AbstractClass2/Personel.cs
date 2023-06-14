using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass2
{
    internal abstract class Personel
    {
        private string Ad;
        private int kimlik;

        //Yapıcı metot :class ile aynı isimde olur
        public Personel(int id)
        {
            kimlik = id;
        }
        public abstract double maas(int katsayi);

        //katsayi için kapsülleme işlemi get/set
        private int katsayi;
        public void setkatsayi(int deger)
        {
            katsayi = deger;
        }
        public int getkatsayi()
        {
            return katsayi;
        }
        //kapsülleme ad için
        public void setad(string isim)
        {
            Ad = isim;
        }
        public string getad()
        {
            return Ad;
        }

        //kapsülleme kimlik için set/get işlemi 
        public void setkimlik(int tc)
        {
            kimlik=tc;
        }
        public int getkimlik()
        {
            return kimlik;
        }
    }
}
