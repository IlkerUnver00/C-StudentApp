using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vektorel.OgrenciUygulamasi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı giriniz:");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız giriniz:");
            string soyad = Console.ReadLine();
            Console.Write("No giriniz:");
            string no = Console.ReadLine();

            //Console.WriteLine(ad+" "+soyad+" "+no);
            //Console.WriteLine("Ad:{0} Soyad:{1} No:{2}",ad,soyad,no);
            Console.WriteLine($"Ad:{ad} Soyad:{soyad} No:{no}");


            //yazisal,karakter,sayisal,tarih-zaman

            




            Console.ReadKey();
        }
    }
}
