namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Array => Dizi
           Birden fazla ayni tipten veriyi bir arada tutmamizi saglayan nesnelerdir


           Cok karsilasilan hata:  Index was outside the bounds of the array 
           Eger bu hatayi alirsaniz bilinki dizinin boyutunu asacak bir islem yapmaktasiniz.


            */

            string arasAd, arasSoyad, arasCep, SevdaAd, SevdaSoyad, SevdaCep, tahaAd, tahaSoyad, tahaCep;
            // 1. Tanimlama [] operatoru ile yapilir. Dizilerde index 0 dan başlar

            string[] isimler = new string[11]; // Heap de 11 elemanli bir string alani olusturur.
            // ikinci Tanimlama 
            int[] sayilar = new int[] { 1, 2, 3, 4, 5 };// Bu 5 elemanli bir diziyi ilk deger atamalari ile  olusturur
            /*
             * sayilar[0] = 1
             * sayilar[1] = 2
             * sayilar[2] = 3
             * sayilar[3] = 4
             * sayilar[4] = 5
             * 
             * 
             */

            // 3. Tanimlama : ilk deger atamalari ile beraber tanimalam

            char[] alfabe = { 'a', 'b', 'c', 'd', 'e', 'f' };
            // Dizinin eleman sayisi .Length propert'si icerisindedir


            //Diziye deger atamasi 
            // {1.01.0001 00:00:00} ,{31.12.9999 23:59:59}
            //DateTime[] tarihler = { DateTime.MinValue, DateTime.MaxValue };
            //tarihler[0] = DateTime.Now;
            //tarihler[1] = DateTime.Now.AddDays(2);

            // Dikkat !!! Asagidaki Satir hata verecektir.
            //tarihler[2] = DateTime.Now.AddDays(3);


            #region Dizi Boyutunu Kullanicidan Alma
            //int elemanSayisi = 0;
            //Console.WriteLine("Dizi eleman Sayisi Giriniz:");
            //elemanSayisi = int.Parse(Console.ReadLine());
            //int[] sayilar2 = new int[elemanSayisi];

            // Diziye rastgele deger atama 
            //Random rand = new Random();

            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    sayilar2[i] = rand.Next();
            //}
            #endregion



            #region Cok Boyutlu diziler
            // iki boyutlu dizi tanimi 
            int[,] sinavsonuclar = new int[2, 4]; // 2 satir ,10 sutun dan olusan bir dizi tanimidir
            //      0  1  2  3    -> ogrenciler  
            // 0 -> 30 40 25 33  -> 1. Vize
            // 1 -> 60 70 50 65  -> 2. Vize
            // Deger Atama
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //Console.WriteLine($"{i} vizenin {j} ogrenciye ait sinav notunu giriniz:");
                    sinavsonuclar[i, j] = rnd.Next();
                }
            }

            // iki boyutlu dizini ekrn ciktisi
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine($"{i},{j} : {sinavsonuclar[i, j]}");
            //    }
            //}

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{j},{i} : {sinavsonuclar[j, i]}  ");
                }
                Console.WriteLine("\n");
            }
            // 3 boyutlu dizi tanimi 
            int[,,] ucBoyutluDizi = new int[4, 5, 3];

            // 4 boyutlu dizi 
            int[,,,] dortBoyutluDizi = new int[3, 5, 6, 2];

            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
