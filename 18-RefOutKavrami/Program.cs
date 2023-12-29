namespace _18_RefOutKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ref kullanırken varsayılan değer ataması zorunludur,
            // Out için bu zorunluluk yoktur.

            //Metot’a out anahtar sözcüğü ile geçilen değişkenin aynı metot içinde
            // değer ataması yapılması zorunlu iken, Ref için böyle bir zorunluluk yoktur.

            // ref disaridakinin referansini alir,
            // out ise iceride yeni bir eleman deklere edilir  ve
            // onun referansi disaridakine atanir ;
            #region Out Ornegi
            //Console.WriteLine("Bir Sayi Giriniz:");
            //string str = Console.ReadLine();
            //int sayi = 0;
            //if (KontrolluSayiAl(str, out sayi))
            //{
            //    Console.WriteLine("Girilen deger integer a cevrildi:" + sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayisal bir dweger giriniz:" + str);
            //} 
            #endregion

            #region Referans ornegi
            //int a, b, c;
            //a = 3; b = 4; c = 5;
            //int toplam = topla(a, ref b);

            int[] sayilar = { 1, 2, 3 }; // sayilar degiskeni stack te , Ama 3 elemanli olan  degerleri heap te tutulur 
            //Sayilar degiskeni onceden 0xAB12C adres bolgesini point ederken 


            DiziBoyutuDegistir(ref sayilar, 10);
            // Bu metod calistirildiktan sonra farkli bir adres bolgesini point eder.
            #endregion
        }

        public static bool KontrolluSayiAl(string sayi, out int deger)
        {

            // Out ile etiketlenen degiskene iceride mutlaka deger atanmasi gerekir. 
            try
            {
                deger = int.Parse(sayi);
                return true;
            }
            catch (Exception ex)
            {
                deger = 0;
                return false;
            }
        }

        public static int topla(int sayi1, ref int sayi2)
        {
            sayi1 =
            sayi2 = 12;
            return sayi1 + sayi2;
        }

        public static void DiziBoyutuDegistir(ref int[] sayiDizisi, int uzunluk)
        {

            int[] yeniDizi = new int[sayiDizisi.Length + uzunluk];
            try
            {
                for (int i = 0; i < sayiDizisi.Length; i++)
                {
                    yeniDizi[i] = sayiDizisi[i];

                }
                sayiDizisi = yeniDizi;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata Olustu");
            }
        }
    }
}
