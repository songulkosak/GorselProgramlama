using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Kısım
            Kisi K1 = new Kisi();
            K1.yas = 32;
            Console.WriteLine(K1.yas);

            Console.WriteLine("----------------------");
            //2.Kısım
            Console.WriteLine("Yaş giriniz :");
            K1.yas=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad giriniz :");
            K1.Ad = Console.ReadLine();
            Console.WriteLine("Soyad giriniz :");
            K1.Soyad = Console.ReadLine();
            Console.WriteLine("Kimlik giriniz :");
            K1.Kimlik = Console.ReadLine();
            Console.WriteLine(K1.yas+""+K1.Ad+""+K1.Soyad+""+K1.Kimlik);

            Console.WriteLine("----------------------");
            //3.Kısım
            int sayi1;
            string sayi2, sayi3, sayi4;
            Console.WriteLine("Yaş giriniz :");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad giriniz :");
            sayi2 = Console.ReadLine();
            Console.WriteLine("Soyad giriniz :");
            sayi3 = Console.ReadLine();
            Console.WriteLine("Kimlik giriniz :");
            sayi4 = Console.ReadLine();
            K1.degerata(sayi1, sayi2, sayi3, sayi4);
            Console.WriteLine(K1.yas + "" + K1.Ad + "" + K1.Soyad + "" + K1.Kimlik);
            Console.ReadKey();
        }
    }
}
