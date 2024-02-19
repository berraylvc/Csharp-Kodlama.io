


using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer("Furkan");
            SelamVer("Berra");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Furkan";
            string ogrenci3 = "Berra";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Furkan";
            ogrenciler[2] = "Berra";
            //ogrenciler[3] = "Berra";  sınırları aşılırsa hata verir.
            //!!! Arrayler, classlar, interfaceler ve abstractlar referans tipleridir. !!!
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antaya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            //!!! int, double, bool tipleri değer tipleridir.
            //!!! referans tiplerinde referans olarak aynı numarayı tuttuklarında, o referans numarasının içeriği
            //değiştiğinde sehirler2 = sehirler1 olduğundan ikisinin de içeriği değişir ,

            // değer tiplerinde referans numarası değil direkt değerin kendisi tutulduğu için
            //değer atandıkktan sonra ilk değer değişirse ikisi de güncellenmez, diğeri atandığı değerde kalır.

            //string normalde bir referans tiptir aslında char array olduğu için, AMA DEĞER TİP GİBİ ÇALIŞIR!

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //Console.WriteLine(sayi2);  

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirtYear = 1985;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Furkan";
            person2.LastName = "Özyalvaç";


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            //sektörde daha çok kullanılanı;

            List<string> yeniSehirler1 = new List<string> { "Trabzon", "Manisa", "Muğla" };
            yeniSehirler1.Add("Bursa");

            foreach (string yeniSehir in yeniSehirler1)
            {
                Console.WriteLine(yeniSehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMaks(person1);




            Console.ReadLine();

        }

        //method isminin yanındaki paranteze yazılan, onun parametresi oluyor.
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString()); 
            return sonuc;
        }


        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            int sayi = 100;
            bool girisYapmisMi = false;


            string ad = "Berra";
            string soyad = "Ozyalvac";
            int dogumYili = 2002;
            long tcNo = 12345678901;



            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
        }
    }


    //pascal casing 
    class Vatandas{
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Dogumyili { get; set; }
        public long TcNo { get; set; }
    }
}
