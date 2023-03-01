using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOzet
{   
    //class Kisi
    //{ 
    //   public string ad;
    //   public string soyad;
    //   public string yas;

    //   public void Yaz()
    //   {
    //        Console.WriteLine("isim : {0}  soyad : {1}  yas : {2}", this.ad, this.soyad, this.yas);
    //   }

    //   public void Yaz(string ad, string soyad, string yas)
    //    {
    //        this.ad = ad;
    //        this.soyad = soyad;
    //        this.yas = yas;
    //        Console.WriteLine("isim : {0}  soyad : {1}  yas : {2}", this.ad, this.soyad, this.yas);

    //    }


    // }

    static class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return str
                .Replace("ç", "c")
                .Replace("ö", "o")
                .Replace("ğ", "g")
                .Replace("ü", "u");
        }

        internal static void KarakterDuzelt()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Burası projenin ilk çalıştırıldığı nokta.

            //          --DEĞİŞKENLER--
            //int sayi1 = 10;
            //int sayi2 = 20;
            //int toplam;

            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);
            //Console.ReadLine();

            //string ad = "isa";
            //string soyad = "demir";
            //string adsoyad = ad + soyad;
            //Console.WriteLine(adsoyad);

            //string sayi1 = "10";
            //string sayi2 = "20";
            //string toplam;
            //toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);

            //bool secim;
            //secim = true;
            //secim = false;
            //Console.WriteLine(secim);
            //Console.ReadLine();


            //           --- DİZİLER ---
            // diziler içindeki elemanlar index numaraları ile birbirinden ayrılır.

            //int[] sayilar = { 10, 20, 30, 40, 55, 60 };
            //Console.WriteLine("1.eleman :{0}", sayilar[0]);
            //Console.WriteLine("2.eleman :{0}", sayilar[1]);
            //Console.WriteLine("3.eleman :{0}", sayilar[2]);
            //Console.WriteLine("4.eleman :{0}", sayilar[3]);
            //Console.WriteLine("5.eleman :{0}", sayilar[4]);
            //Console.WriteLine("6.eleman :{0}", sayilar[5]);

            //string[] isimler = { "ahmet", "mehmet", "ali", "hasan" };
            //Console.WriteLine("1.eleman :{0}", isimler[0]);
            //Console.WriteLine("2.eleman :{0}", isimler[1]);
            //Console.WriteLine("3.eleman :{0}", isimler[2]);
            //Console.WriteLine("4.eleman :{0}", isimler[3]);
            //Console.ReadLine();


            //          --- KONTROL İFADELERİ ---  if else , switch case

            //int not = 55;
            //if (not < 0)
            //{
            //    //burası kontrolün sonucu true olduğunda çalışır.
            //    Console.WriteLine("Not Bilgisi 0'dan küçük olamaz!");
            //}
            //else
            //{
            //    //burası kontrolün sonucu false olduğunda çalışır.
            //    Console.WriteLine("Not Bilginiz : {0}", not);

            //    if (not < 50)
            //    {
            //        Console.WriteLine("Kaldınız");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçtiniz");
            //    }
            //}

            //   -- SWITCH CASE --
            //string gun = "carsamba";
            //switch (gun)
            //{
            //    case "pazartesi":
            //        Console.WriteLine("Günlerden pazartesi");
            //        break;
            //    case "sali":
            //        Console.WriteLine("Günlerden sali");
            //        break;
            //    case "carsamba":
            //        Console.WriteLine("Günlerden carsamba");
            //        break;
            //    case "persembe":
            //        Console.WriteLine("Günlerden persembe");
            //        break;
            //    case "cuma":
            //        Console.WriteLine("Günlerden cuma");
            //        break;
            //    case "cumartesi":
            //        Console.WriteLine("Günlerden cumartesi");
            //        break;
            //    case "pazar":
            //        Console.WriteLine("Günlerden pazar");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış bir gün girdiniz");
            //        break;
            //}



            //            --- DÖNGÜLER ---
            // -- FOR DÖNGÜSÜ --   --WHİLE DÖNGÜSÜ--   --FOREACH DÖNGÜSÜ--

            //int[] sayilar = { 10, 20, 30, 40, 50, 60 };
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //int  i = 0;
            //while (i < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[i]);
            //    i++;
            //} 


            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}



            //              --- SINIF ---

            //string[] isimler = { "ahmet", "mehmet", "ali" };
            //string[] soyadlar = { "turan", "kazan", "demir" };
            //string[] yaslar = { "10", "20", "30" };

            //Console.WriteLine("isim : {0} soyad : {1} yas : {2}", isimler[0], soyadlar[0], yaslar[0]);


            //Kisi k1 = new Kisi();
            //k1.ad = "ahmet";
            //k1.soyad = "turan";
            //k1.yas = "50";


            //Kisi k2 = new Kisi() { ad = "isa", soyad = "demir", yas = "24" };
            //Kisi k4 = new Kisi();

            //Console.WriteLine("ad : {0}  soyad : {1}  yas : {2}", k1.ad, k1.soyad, k1.yas);
            //Console.WriteLine("ad : {0}  soyad : {1}  yas : {2}", k2.ad, k2.soyad, k2.yas);


            //   ---- METOTLAR ----

            //k1.Yaz();
            //k2.Yaz();
            //k4.Yaz("sadık", "turan", "34");

            // --- STATIC SINIFLAR ---

            string str = " ölçme ve değerlendirme";

            str = HelperMethods.KarakterDuzelt(str);
            Console.WriteLine(str);


            Console.ReadLine();

        }
    }
}
