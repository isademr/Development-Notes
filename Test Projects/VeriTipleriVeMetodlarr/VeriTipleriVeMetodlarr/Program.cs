using System;

namespace VeriTipleriVeMetodlarr
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //topla();
            //ErisimBelirtecleriOgrenme erisimBelirtecleriOgrenme = new ErisimBelirtecleriOgrenme();
            //erisimBelirtecleriOgrenme.GetProperty();

            int sayi1, sayi2;
            //Console.Write("Bir sayi giriniz :");
            //s1 = int.Parse(Console.ReadLine());
            //Console.Write("Bir sayi giriniz :");
            //s2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(s1 + " + " + s2 + " = " + (s1 + s2));
            Console.Write("Bir sayi giriniz :");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Bir sayi giriniz :");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Topla(sayi1, sayi2));
            Console.WriteLine(Cikart(sayi1, sayi2));
            Console.WriteLine(Carp(sayi1, sayi2));
            Console.WriteLine(Bol(sayi1, sayi2));

           
            Console.ReadKey();
            
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
            
        }
        static int Cikart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        static int Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        static double Bol(int sayi1,int sayi2)
        {
            double  sonuc = (double)sayi1 / sayi2;
            return sonuc;
        }
        /*
         * Bol 
         * İki parametre - türleri int olacak
         * Birinci sayıyı mı yoksa ikinci sayıyı mı böleceksin
         * tip dönüşümü
         * Ya bir değişkene ata ya da metodtan dön
         * 
         * 
         * 3 tane sayı alıp onları toplayan metod
         * 4 sayı alıp bunları toplayan metod
         * 5 sayı alıp bunları çarpan metod
         * 
         * Kullanıcıdan +, -, *, /, q 
         * Seçilen işleme göre hesaplama yapılacak
         * kullanıcı q ya basarsa program duracak
         * 
         * 
         */

        string AdSoyadBirlestir(string Ad, string Soyad)
        {
            return Ad + Soyad;
        }
        void AdSoyadBirlestir2(string Ad, string Soyad)
        {
             var c = Ad;
        }
    }
}
