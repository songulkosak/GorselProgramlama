using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CokBicimlilikPolymorphism
{
    internal class Hayvan
    {
        protected string isim, ses, kimlik;
        public string getbilgi
        {
            get {return kimlik; }
            set { }
        }
        public Hayvan()
        {
            this.isim = null;
            this.ses=null;
            this.kimlik = null;
        }
        public Hayvan(string isim, string ses)
        {
            this.isim=isim;
            this.ses=ses;
            this.kimlik = null;
        }
        public Hayvan(string isim,string ses,string bilgi)
        {
            this.isim= isim;
            this.ses=ses;   
            this.kimlik = bilgi;
        }
        public void yazdir()
        {
            Console.WriteLine("Hayvan Bilgisi :\n"+"İsim :"+ isim+ "\nSes :" + ses+ "\nKimlik :" + kimlik);
        }
    }
}
