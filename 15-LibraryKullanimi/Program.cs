using _14_MyLibrary;
namespace _15_LibraryKullanimi
{


    internal class Program
    {
        public static int Topla(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {


            //Static classlari direk kullanabiliriz
            //int sayi = Matematik.SayiOku("Bir Sayi Giriniz :");
            //Console.WriteLine("Gelen Deger:" + sayi);

            // Static Olmayan Class'lari ise new operatoru ile instance alarak kullanabiliriz

            //Istatistik ist = new Istatistik();
            //double ortalama = ist.Ortalama(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //Console.WriteLine(ortalama);

            //decimal sonuc = Matematik.Faktoryel("Bir sayi Giriniz:");
            //Console.WriteLine("faktoryel : " + sonuc);

            #region Asal Sayi Kontrolu

            //bool result = Matematik.Asalmi("Kontrol edilecek sayiyi Giriniz:");
            //if (result)
            //{
            //    Console.WriteLine("Sayi asaldir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi asal degildir");
            //}
            #endregion

            //List<string> kelimeler = new List<string>();
            //kelimeler.Add("Elma");
            //kelimeler.Add("Armut");
            //kelimeler.Add("Ali");
            //kelimeler.Add("veli");
            //kelimeler.Add("Kalem");
            //string paragraf = "Ali Veli 49 50 . bugun gunlerden pazar. Fenerbahce galatasaray derbisi var. Aksam saat 19 da.";
            //Console.WriteLine("Cumle Sayisi : " + StringIslemleri.CumleSayisi(paragraf));
            //Console.WriteLine("Cumle Sayisi : " + StringIslemleri.KelimeSayisi(paragraf));
            //Console.WriteLine("Yasakli kelime kullanilmistir: " + StringIslemleri.Sansur(kelimeler, paragraf));
            //decimal sonuc = Matematik.Faktoryel("Bir sayi giriniz:");
            //Console.WriteLine("Sonuc:" + sonuc);




            Istatistik ist = new();
            var sonuc = ist.Ortalama(1, 2, 3, 4, 5, 6, 7);
        }
    }
}
