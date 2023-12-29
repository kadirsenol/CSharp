namespace _13_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aciklama
            /*
          Metodlar sadece kendi isini yapan subrutin kodlardir.
          1- Tekrarli kodlari engeller
          2- Kod Kalabalikligindan kurtarir.
          Genel Anlamada Metodlar 2 'ye ayrilir.

           - Geriye deger Donmeyen Metodlar : 
               1- Parametre alan metodlar 
               2- Parametre almayan Metodlar
           - Geriye bir deger donen metodlar.
              1- Parametre alan metodlar cls

              2- Parametre almayan Metodlar

          */
            #endregion
            //foreach (var arg in args)
            //{
            //    Console.WriteLine(arg);
            //}

            // EkranaBas();
            Topla(3, 5);

            int toplam = Topla(3, 5);
            Console.WriteLine(Topla(5, 6));
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Topla(sayilar);

            //Asagidaki kullanim params keyword u ile yapilabilir.
            //Degisken sayida parametre alabilmek icin kullanilir.

            Topla(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //Console.WriteLine("Hello, World!");
            Islem("topla", 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        //Parametre almayan ve Geriye bir deger donmeyen metod
        static void EkranaBas()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //EkranaBas metodunun overload edilmis halidir.
        //Yani Geriye bir sey donmeyen ve string parametre alan bir metod
        static void EkranaBas(string str)
        {

            Console.WriteLine(str);


        }

        static void EkranaBas(int sayi)
        {

            Console.WriteLine(sayi);

        }


        static int Topla(int a, int b)
        {
            return (a + b);
        }
        static int Topla(int a, int b, int c)
        {
            return (a + b + c);
        }
        //static int Topla(int[] sayilar)
        //{
        //    int toplam = 0;
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        toplam += sayilar[i];
        //    }
        //    return toplam;

        //}

        //Metod içinde params ile tanımlanan diziye, dışarıdan istenildiği sayıda eleman gönderebiliriz.

        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        //  params keywordu herzaman  parametre listesinin en sonuda bulunmalidir
        static decimal Islem(string islem, int a, float b, params int[] sayilar)
        {
            decimal sonuc = 0;
            if (islem == "Topla")
            {
                for (int i = 0; i < sayilar.Length; i++)
                {
                    sonuc += sayilar[i];
                }
            }
            else if (islem == "Carp")
            {
                for (int i = 0; i < sayilar.Length; i++)
                {
                    sonuc *= sayilar[i];
                }



            }
            return sonuc;
        }
    }
}
