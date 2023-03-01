using System;
using System.Security.Cryptography.X509Certificates;

namespace VeriTipleriVeMetodlarr
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //topla();
            //ErisimBelirtecleriOgrenme erisimBelirtecleriOgrenme = new ErisimBelirtecleriOgrenme();
            //erisimBelirtecleriOgrenme.GetProperty();

            int sayi1, sayi2, sayi12, sayi13, sayi14, sayi15, sayi21,sayi22,sayi23,sayi24,sayi25; 
            double sayii1 = 0, sayii2 = 0;
            //Console.Write("Bir sayi giriniz :");
            //s1 = int.Parse(Console.ReadLine());
            //Console.Write("Bir sayi giriniz :");
            //s2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(s1 + " + " + s2 + " = " + (s1 + s2));

            string islem;
            Console.Write("Birinci sayiyi giriniz: ");
            sayii1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayiyi giriniz: ");
            sayii2 = Convert.ToDouble(Console.ReadLine());

            OkuOperator:
            Console.Write("Operatorlerinden(+,-,*,/) birini giriniz: ");
            islem = Console.ReadLine();

            if (islem == "+")
                Console.WriteLine("Toplam = {0}", (sayii1 + sayii2).ToString());
            else if (islem == "-")
                Console.WriteLine("Fark = {0}", (sayii1 - sayii2).ToString());
            else if (islem == "*")
                Console.WriteLine("Çarpım = {0}", (sayii1 * sayii2).ToString());
            else if (islem == "/")
                Console.WriteLine("Bölüm = {0}", (sayii1 / sayii2).ToString());
            else
            {
                Console.WriteLine("Yanlış operatör girdiniz. Tekrar deneyiniz...");
                goto OkuOperator;
            }


            Console.Write("Sayi gir :");
            sayi21 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi gir :");
            sayi22 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi gir :");
            sayi23 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi gir :");
            sayi24 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi gir :");
            sayi25 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Bir sayi giriniz :");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Bir sayi giriniz :");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Topla(sayi1, sayi2));
            Console.WriteLine(Cikart(sayi1, sayi2));
            Console.WriteLine(Carp(sayi21, sayi22, sayi23, sayi24, sayi25));
            Console.WriteLine(Bol(sayi1, sayi2));
            int toplam = 0;
            


            //for (int i = 0; i <= 4; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("Toplam = {0}", toplam);

            Console.Write("Sayi giriniz :");
            sayi12 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi giriniz :");
            sayi13 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi giriniz :");
            sayi14 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayi giriniz :");
            sayi15 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(Topla(sayi12, sayi13, sayi14, sayi15));



            Console.ReadKey();

        }

        static int Carp(int sayi21, int sayi22, int sayi23, int sayi24, int sayi25)
        {
            int sonuc = sayi21 * sayi22 * sayi23 * sayi24* sayi25;
            return sonuc;
        }

        static int Topla(int sayi12, int sayi13, int sayi14, int sayi15)
        {
            int sonuc = sayi12 + sayi13 + sayi14 + sayi15;
            return sonuc;
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
        //static int Carp(int sayi1, int sayi2)
        //{
        //    int sonuc = sayi1 * sayi2;
        //    return sonuc;
        //}
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
         * 
         * Kullanıcıdan kaç sayı ile işlem yapacağını sor örn: 5
         * Sonra beş deva readline ile değer girmesini iste
         * sonra hangi işlemin yapılcağının sor 
         * 
         * 
         * 
         * 
         * 
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
