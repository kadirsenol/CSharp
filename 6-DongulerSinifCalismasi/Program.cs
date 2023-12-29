namespace _6_DongulerSinifCalismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2015 ila 2023 arasindaki yillari 2020  haric butun dongulerle bastirin
            int yil = 2015;
            #region while dongusu ile
            //while (yil < 2024)
            //{
            //    if (yil != 2020)
            //    {
            //        Console.WriteLine(yil);

            //    }

            //    yil++;
            //}

            // Continue ile yazlabilir

            //while (yil < 2024)
            //{
            //    if (yil == 2020)
            //    {

            //        continue; // Dongude bir sonraki step'e gecer
            //    }
            //    Console.WriteLine(yil);
            //    yil++;
            //}

            // Break komutu ise dongusyu kirar ama metod'tan disari cikamaz. Yani return degildir.
            // Sadece donguden cikar

            //while (yil < 2024)
            //{
            //    if (yil == 2020)
            //    {

            //        break; // Donguyu kirar ama metod disina cikmaz
            //    }
            //    Console.WriteLine(yil);
            //    yil++;
            //}

            //return kullanilirsa direk programdan cikar 

            //while (yil < 2024)
            //{
            //    if (yil == 2020)
            //    {

            //        return; // Donguyu kirar ama metod disina cikmaz
            //    }
            //    Console.WriteLine(yil);
            //    yil++;
            //} 
            #endregion

            #region Do-While ile 
            //do
            //{
            //    if (yil != 2020)
            //    {
            //        Console.WriteLine(yil);

            //    }

            //    yil++;
            //} while (yil < 2024); // Sart en sonda bulunur
            #endregion
            #region for ile 


            //for (int i = 2015; i < 2024; i++)
            //{
            //    // Eger if'ten sonra tek satirlik bir komut varsa scope 
            //    // Acmaya gerek yoktur
            //    if (i == 2020) continue;

            //    Console.WriteLine(i);
            //}
            #endregion



            Console.WriteLine("Hello World");
            #endregion


            #region yazi tura Similasyonu nu 3 dongu ile yapiniz.
            // Deneme sayisi ekrandan okutulacak

            //int denemeSayisi = 0, yaziSayisi = 0, turaSayisi = 0, index = 0, gelenDeger = 0;
            //Random rnd = new Random();
            //Console.WriteLine("Deneme Sayisi Giriniz:");
            //denemeSayisi = Convert.ToInt32(Console.ReadLine());

            #region Do ile Cozumu
            //do
            //{
            //    gelenDeger = rnd.Next(2);
            //    if (gelenDeger == 0)
            //    {
            //        turaSayisi++;
            //    }
            //    else
            //    {
            //        yaziSayisi++;
            //    }
            //    index++;
            //} while (index < denemeSayisi); 
            #endregion
            #region While ile cozumu.
            //while (index < denemeSayisi)
            //{
            //    gelenDeger = rnd.Next(2);
            //    if (gelenDeger == 0)
            //    {
            //        turaSayisi++;
            //    }
            //    else
            //    {
            //        yaziSayisi++;
            //    }
            //    index++;
            //} 
            #endregion

            #region For ile Cozumu
            //for (int i = 0; i < denemeSayisi; i++)
            //{
            //    gelenDeger = rnd.Next(2);
            //    if (gelenDeger == 0)
            //    {
            //        turaSayisi++;
            //    }
            //    else
            //    {
            //        yaziSayisi++;
            //    }
            //}
            #endregion


            //Console.WriteLine($"Gelen Yazi Sayisi {yaziSayisi} Gelen Tura Sayisi {turaSayisi} ");
            //Console.WriteLine($"Yazi Olasiligi : {yaziSayisi / (float)denemeSayisi} Tura Olasiligi : {turaSayisi / (float)denemeSayisi}");

            #endregion


            #region For ile Sonsuz Dongu 
            //for (; ; )
            //{
            //    Console.WriteLine("test ");
            //}
            #endregion
            #region Çarpim Tablosunu Ekrana Basiniz
            /*1x1=1
             *1x2=2 
             *1x3=3 
             * 
             * 
             * 
             * 
             * 1x9=9
             */

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} ={i * j}");
            //    }
            //    Console.WriteLine("\n\n");
            //}
            #endregion

            #region Zar Similasyonu nu yapiniz. Deneme Sayisi disaridan alinacak

            //int denemeSayisi = 0, gelenSayi = 0;
            //int birlerToplami = 0, ikilerToplami = 0, uclerToplami = 0, dortlerToplami = 0, beslerToplami = 0, altilarToplami = 0;

            //Console.WriteLine("Deneme Sayisini Giriniz:");
            //denemeSayisi = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            #region Spagetti Kod
            //for (int i = 0; i < denemeSayisi; i++)
            //{
            //    gelenSayi = rnd.Next(6);
            //    if (gelenSayi == 0)
            //    {
            //        birlerToplami++;
            //    }
            //    else if (gelenSayi == 1)
            //    {
            //        ikilerToplami++;
            //    }
            //    else if (gelenSayi == 2)
            //    {
            //        uclerToplami++;
            //    }
            //    else if (gelenSayi == 3)
            //    {
            //        dortlerToplami++;
            //    }
            //    else if (gelenSayi == 4)
            //    {
            //        beslerToplami++;
            //    }
            //    else
            //    {
            //        altilarToplami++;
            //    }

            //}

            //Console.WriteLine($"1:{birlerToplami} \n 2:{ikilerToplami}\n 3:{uclerToplami}\n 4:{dortlerToplami} \n 5:{beslerToplami} \n 6:{altilarToplami}");
            //Console.WriteLine($"1:{birlerToplami / (float)denemeSayisi} \n 2:{ikilerToplami / (float)denemeSayisi}\n 3:{uclerToplami / (float)denemeSayisi}\n 4:{dortlerToplami / (float)denemeSayisi} \n 5:{beslerToplami / (float)denemeSayisi} \n 6:{altilarToplami / (float)denemeSayisi}");
            #endregion

            #region Dizi ile Cozumu
            int[] zar = new int[6];
            //for (int i = 0; i < denemeSayisi; i++)
            //{

            //    gelenSayi = rnd.Next(6);
            //    zar[gelenSayi]++;
            //}

            /* For Each Bir iterasyondur
             * Dongu degildir. Mutlaka bir veri setine ihtiyac duyar
             * for dongusu gib kurgulanamaz.
             * Buradaki ornekte zar dizisi icerisindeki elemanlari tektek 
             * 0'dan başlayacak şekilde itere eder. Yani Dolasir.
             */
            //foreach (int i in zar)
            //{
            //    Console.WriteLine(i);
            //}

            //Burasi da dizi icerisinin for dongusu ile ekrana yazdirilmasi

            //for (int i = 0; i < zar.Length; i++)
            //{
            //    Console.WriteLine(zar[i]);
            //}
            #endregion
            #endregion

            #region Sayi Tahmin Oyununu Yapiniz


            #endregion





            #region ilk 20 fibanocci sayilarini ekrana basiniz

            #endregion

            #region Girilen Sayinin Faktoryelini aliniz ve devam etmek istiyormu diye sorunuz.

            #endregion

            #region Girilen sayinin Asal sayi olup olmadigini bulunuz ve devam etmek istiyormu diye sorunuz.

            #endregion

        }


    }
}
