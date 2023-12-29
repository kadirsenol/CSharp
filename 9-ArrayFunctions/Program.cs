namespace _9_ArrayFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Sinifi
            // Su ana kodar gordugumuz ilkel diziler bize cok esneklik saglamadi.
            //Microsoft muhendislerinin gelistirdigi Array sinifi diziler yeniden boyutlandirmak,
            //siralamak ,temizlemek icin gerekli araclari sunar.
            int[] sayilar = { 4, 2, 3, 41, 5, 1, 7, 12, 9, 10 };
            string[] sehirler = { "Adana", "Ankara", "Muş", "Izmir", "Istanbul", "Muş", "Bursa", "Kocaeli", "Samsun", "Muş", "Eskisehir" };
            int sayi = 4;
            #region Manuel Yeniden boyutlama
            // Mevcut dizinin boyutunu degistirme manuel yontem

            //int[] sayilar2 = new int[20];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar2[i] = sayilar[i];
            //}
            //sayilar = sayilar2; // Burada sayilar2 'nin tuttugu heap deki adres bolgesi sayilar degiskenine atanir. 
            #endregion

            //ref keyword'u heap yada stack deki adresi bildirir


            #region Yeniden Boyutlama
            //Array.Resize(ref sayilar, 20);
            //foreach (int i in sayilar)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            // Sort : Siralama islemi

            #region Siralama islemi
            //Array.Sort(sayilar);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Clear 
            // 1. Parametre kaynak dizi
            //2. Parametre nereden başlayacagi
            // 3. Parametre kac adet silecegi

            //Array.Clear(sayilar, 2, 2);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("*************************");
            //Array.Clear(sayilar, 4, 4);
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Copy
            /* 
             * Array.Copy => Bir diziden başka bir diziye eleman kopyalar
             1. Kullanim Sekli
             */
            //int[] sayilar2 = new int[10];
            //Array.Copy(sayilar, sayilar2, 5);
            //foreach (var item in sayilar2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region IndexOf
            /*
            Dizide aranan elemanin index numarasini dondurur
            */

            //Console.WriteLine("Şehir adi giriniz:");
            //string sehir = Console.ReadLine();
            //int index = Array.IndexOf(sehirler, sehir);
            //Console.WriteLine($"{index} {sehir}");

            #endregion
            #region LastIndexOf
            /*
             Dizide aranan elemanin index numarasini dondurur
             */
            //Console.WriteLine("Sehir Adi Giriniz:");
            //string sehir = Console.ReadLine();
            //int index = Array.LastIndexOf(sehirler, sehir);

            //Console.WriteLine($"{index} {sehir}");
            #endregion
            #region Reverse Terse cevirme
            Array.Reverse(sehirler);

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }


            #endregion

        }
    }
}
