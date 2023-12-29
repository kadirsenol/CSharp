namespace _10_Listeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<> icerisine (<T>ype) verilen tipe burunerek o tiple ilgili ArrayList ozelligine kavusur. Veri sayisinin belirsiz oldugu durumlarda Listeler kullanislidir

            List<int> sayilar = new List<int>(); // Sayisal liste
            List<string> sehirler = new List<string>(); //string liste
            List<DateTime> dates = new List<DateTime>(); // Tarih Listesi
            List<bool> bools = new(); // Logic Liste

            Random rnd = new();
            #region Listelere Eleman Ekleme
            // 0 girene kadar listeye elelman ekleme
            //int giris = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayi Giriniz");
            //    giris = int.Parse(Console.ReadLine());
            //    if (giris == 0)
            //    {
            //        break;
            //    }
            //    sayilar.Add(giris);
            //}

            //Listeleri Bastirma
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Rastgele sayi atama
            int gelen = 0;
            for (int i = 0; i < 100; i++)
            {
                gelen = rnd.Next(50);
                if (sayilar.Contains(gelen))
                {
                    continue;
                }
                sayilar.Add(gelen);
            }
            Console.WriteLine(sayilar);
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Maximum :" + sayilar.Max());
            Console.WriteLine("Minimum:" + sayilar.Min());
            Console.WriteLine("Toplam:" + sayilar.Sum());



            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
