namespace _5_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Konu Anlatimi
            string mesaj;
            int index = 0;
            /*
            Uç Adet Döngümüz Vardir
            For,While,Do-While 
            Foreach bir dongu degildir!! İterasyon dur
            */
            #region For Dongusu

            /*
             For dongusu : Bir başlangic degeri olan ve bir kosula dek devam eden ve belirledigimiz artişa göre hareket eden bir yapidir
             Syntax : 
                for(başlangiç;koşul;artim)
                {

                }
             */

            // For dongusu : 1-10 arasindaki cift sayilari ekrana bastiralim

            //for (int i = 1; i <= 10; i++)
            //{
            //    //if (i % 2 == 0)
            //    //{
            //    //    Console.WriteLine(i + " Cifttir");
            //    //}

            //    // ternary if ile 
            //    mesaj = i % 2 == 0 ? i + " cifttir" : "";
            //    Console.WriteLine(mesaj);
            //}

            #region  100 e kadar olan sayilarin toplami , ortalamasi nedir ?

            // iki integer sayini bolumu integer cikar. Eger Kusuratli cikmasini istiyor isek 
            // pay yada paydanin birisinin float v.b.. veri tipinde olmasi gerekir

            //int toplam = 5050;
            //double ortalama = 5050 / 100.0f;
            //Console.WriteLine($"Ortalama {ortalama}");
            //ortalama = 5051 / 100;
            //Console.WriteLine($"Ortalama {ortalama}");
            //int toplam = 0;
            //float ortalama;
            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam = toplam + i;
            //}
            ////ortalama = toplam / 100;  burasi integer sonuc verir. O yuzden paydayi float yapmak lazim
            //ortalama = toplam / 100.0f;
            //Console.WriteLine($"Toplam :{toplam} , Ortalam : {ortalama}");
            //Console.WriteLine("Toplam :" + toplam + " , Ortalam : " + ortalama);
            #endregion

            #region  Rastgele 20 adet sayi olusturup Ortalamasi ve toplamini bulunuz 
            //Random rnd = new Random();
            //int adet = 0, toplam = 0;
            //float ortalama = 0;
            ////var ortalama3; Bu kullanim yanlistir.
            //Console.WriteLine("Olusturulacak olan Rastgele Sayi adedini giriniz :");
            //adet = int.Parse(Console.ReadLine());
            //int[] sayilar = new int[adet];
            //for (int i = 0; i < adet; i++)
            //{
            //    sayilar[i] = rnd.Next(1000) + 1;
            //    Console.WriteLine(sayilar[i]);
            //    toplam += sayilar[i]; // Burasi toplam = toplam + sayilar[i] ifadesi ile ayni ifadedir
            //}
            //var ortalama2 = (toplam / (float)adet);
            //Console.WriteLine($"Toplam :{toplam} , ortalama : {ortalama2}");
            #endregion


            #endregion

            #region While Dongusu 
            //While döngüsü koşul doğru olduğu sürece işlemleri gerçekleştiren bir döngü tipidir.
            //Eğer koşu yanlış işe döngü tamamlanır.
            //for döngüsünde olduğu gibi, bir koşul sağlandığı sürece dönmeye devam eder.
            //Koşul yanlış(false) sonucunu verdiği zaman ise sonlandırılır.
            //Genel yazım şekli şöyledir:

            //while (kosul)
            //{
            //    continue;
            //    break;
            //}

            #region Tek Sayi girilince sonlana dongu 
            //int sayi = 0;
            //while (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Cift sayi giriniz, çıkmak icin tek sayi giriniz");
            //    sayi = int.Parse(Console.ReadLine());
            //    Console.WriteLine(sayi);
            //}

            #region  Devam etmek istiyormusunuz soruna [E/H] 'H' girilene kadar donecek while dongusu
            //string devam = "";
            //int sayac = 0;
            //while (devam.ToUpper() != "H")
            //{
            //    sayac++;
            //    Console.WriteLine("Devam Etmek istiyormusunuz ?");
            //    devam = Console.ReadLine();
            //    Console.WriteLine(sayac);
            //}
            #endregion
            #endregion
            #endregion

            #region Do-While dongusu
            /*
             *  While Dongusunden farkli olarak kontrol ifadesi en son yapilir. 
             *  Bunda amac bir kerede olsa dongunun icerisine girmektir.
             * 
             * do
             * {
             * 
             * }while(sart) 
             * 
             */
            bool devam = false;
            string cevap = "";
            //do
            //{
            //    Console.WriteLine("Devam Etmek istiyormusunuz [E/H] ? ");
            //    cevap = Console.ReadLine();
            //    //devam = cevap == "E" ? true : false;
            //    if (cevap.ToUpper() == "E")
            //    {
            //        devam = true;
            //    }
            //} while (devam);
            int sayac = 0;
            //do
            //{
            //    Console.WriteLine("Sayac:" + sayac);
            //    sayac++;
            //} while (sayac < 10);



            #endregion

            #endregion


        }
    }
}
