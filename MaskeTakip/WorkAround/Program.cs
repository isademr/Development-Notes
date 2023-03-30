using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;

namespace WorkAround
{
     class Program
     {
        static void Main(string[] args)
        {
            //değişkenler();
            //Variables();

           Vatandas vatandas1 = new Vatandas(); // Bir tane insan oluşturdum. 
            SelamVer( isim : "İsa");
            SelamVer( isim : "Ahmet");
            SelamVer( isim : "Ayşe");
            SelamVer();
            
            int sonuc = Topla(6,58);

            //Diziler //Arrays

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "İsa";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";
            
            for( int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "İsa";
            person1.LastName = "Demir";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity = 1;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add(item: "Adana1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);











            Console.ReadLine();
        }

        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba :"  + isim);
        }

        static int Topla(int sayi1 = 5 , int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " +sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string message = "Selam";
            double amount = 10000; // db(veritabanı) den gelir 
            int number = 100;
            bool login = false;

            string ad = "İsa";
            string soyad = "Demir";
            int dogumYili = 1998;
            long tcNo = 10336649934;

            

            Console.WriteLine(amount * 1.18);

            Console.WriteLine(message);
        }
     }

      public class Vatandas
      {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumYili { get; set; }
        public string TcNo { get; set; }

      }
}
