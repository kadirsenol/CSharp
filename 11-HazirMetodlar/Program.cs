namespace _11_HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Hazir Metodlar (Buildin metodlar)
            string haber = @"Haberler Türkiye Haberleri Son Dakika Haberi: 81 İlde Kaçak Sigara Ve Elektronik Sigara Operasyonu
        SON DAKİKA HABERİ: 81 ilde kaçak sigara ve elektronik sigara operasyonu
        SON DAKİKA HABERİ: İçişleri Bakanı Ali Yerlikaya, 81 ilde yasa dışı tütün mamülü üretimi ve satışı yapanlara yönelik operasyonlarda 457 şüpheli hakkında işlem yapıldığını açıkladı.

13.091.486 adet doldurulmuş makaron

9.319.210 adet boş makaron

81.030 paket sigara

8.908 kg tütün mamulü,

9.429 adet puro,

12.913 adet elektronik sigara ve likiti,

9.239 adet sahte bandrol";

            string cumle = "Bugun gunlerden cumartesi . Yarin Fenerbahce - Galatasaray Derbisi var.";
            // Console.WriteLine("Haber uzunlugu :" + haber.Length);

            // Kaçak kelimesinin başladigi index 
            int index = haber.IndexOf("Kaçak");
            // Console.WriteLine("KElimenin başlangic Indexi" + index);

            // Split : Encok kullanilan metodlardan biridir. Verilen ayraca gore string ifadeyi parcalar ve dizi olarak geri doner

            // Ornek HAberdeki cumle sayisini bulalim.
            #region Cumlelerin bulunmasi
            string[] cumleler = haber.Split('.');

            //foreach (var item in cumleler)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Kelimelere ayirma
            // KElimeler icin bosluklara gore split yapilabilir
            var kelimeler = haber.Split(' ');
            //foreach (var item in kelimeler)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Replace
            // Cumlede gecen fenerbahce yerine Fener Aglama yazsin 
            //string yeniCumle = cumle.Replace("Fenerbahce", "Ağlama Fener");
            //Console.WriteLine(yeniCumle);
            //Console.WriteLine(cumle);
            #endregion


            #region Substring 
            // // Substring :Belirtilen yerden , belirtilen kadar veri cekmeye yarayan metod
            // Console.WriteLine(cumle.Substring(6)); // ilk 6 karakter geçer , geri kalan cumleniin tamamini verir

            // Console.WriteLine(cumle.Substring(6, 6));
            // Cumartesi kelimesini ayiklayalim

            // Console.WriteLine(cumle.Substring(16, 9));
            //Daha kisa yolu 
            string kelime = "cumartesi";
            int kelimeIndex = cumle.IndexOf("cumartesi");
            int kelimeSayisi = kelime.Length;
            //Console.WriteLine(cumle.Substring(kelimeIndex, kelimeSayisi));

            #region StartWith
            // StartWith: verilen parametre ile başlayip başlamadigini kontrol eder
            // Geriye bool doner . Yani true yada false doner
            //if (cumle.StartsWith(kelime))
            //{
            //    Console.WriteLine("Dogru");
            //}
            //Console.WriteLine("Yanlis");

            // EndsWith: verilen parametre ile bitip bitmedigini kontrol eder
            //kelime = "var.";
            //if (cumle.EndsWith(kelime))
            //{
            //    Console.WriteLine("Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlis");
            //}

            #endregion
            #region Insert
            //Insert : 
            //Console.WriteLine(cumle.Insert(6, "Ali "));
            ////Remove :
            //Console.WriteLine(cumle.Remove(6, 9));
            #endregion
            #endregion

            #endregion
            #region Trim
            string str = "          Ali Veli 49 50    ";
            //Console.WriteLine(str.Trim()); // Butun bosluklari atar
            //Console.WriteLine(str.TrimStart());
            //Console.WriteLine(str.TrimEnd());

            #endregion


            #region Butun string ifadeler char[] dizisidir
            //foreach (var item in kelime)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime[i]);
            //}
            #endregion

            #region null deger olup olmadigi bilgisi
            // verilen ifadenin boş olup olmadigi ve ayni zamanda null olup olmadigini kontrol eder. 
            //string kelime2 = "";
            //if (string.IsNullOrEmpty(kelime2))
            //{
            //    Console.WriteLine("kelime boştur");
            //}
            //if (string.IsNullOrWhiteSpace(kelime2))
            //{
            //    Console.WriteLine("kelime bosluk iceriyor");
            //}
            #endregion


            #region Math Kutuphanesi



            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.E);
            ////Ceiling => Verilen ondalikli sayiyi bir uste yuvarlar
            //Console.WriteLine(Math.Ceiling(10.2));
            //Floor => Verilen ondalikli sayiyi bir alta yuvarlar
            //Console.WriteLine(Math.Floor(10.9));

            //Round => Verilen ondalikli sayiyi yaridan fazlasini bir uste yuvarlar,yaridan azini bir alta yuvarlar
            //Console.WriteLine("********* Round *************");
            //Console.WriteLine(Math.Round(10.4));
            //Console.WriteLine(Math.Round(10.6));
            //Console.WriteLine(Math.Round(10.5));
            //Console.WriteLine(Math.Round(11.5));
            //Console.WriteLine(Math.Round(12.5));
            //Console.WriteLine(Math.Round(13.5));



            //Console.WriteLine("**************************");

            //Console.WriteLine("25'in kare koku :" + Math.Sqrt(25));
            //Console.WriteLine("81'in kare koku :" + Math.Sqrt(81));
            //Console.WriteLine("**************** Kuvvet alma : Power");
            //Console.WriteLine(Math.Pow(2, 3));// 8 verecektir
            //Console.WriteLine(Math.Pow(27, 1.0 / 3));

            //// Sign : Bir sayin negatif , pozitif ve 0 olma durumunu saglayan fonksiyon 
            //// Eger sayi negatif ise -1 , pozitif ise 1, 0 ise 0 doner.
            //Console.WriteLine("*********** Sign metodu ***********");

            //Console.WriteLine(Math.Sign(-20));
            //Console.WriteLine(Math.Sign(20));
            //Console.WriteLine(Math.Sign(0));


            //Console.WriteLine("**************** Truncate ***********");
            //// Sayinin tam kimini veriri. Ondalikli kismini atar

            // Console.WriteLine(Math.Truncate(12.7));

            //Console.WriteLine("**************** Mutlak Deger : ABS ***********");
            //// Sayinin Mutlak degerini verir

            //Console.WriteLine(Math.Abs(-5));
            #region Sayilarin Taban Cevreimleri ile gosterimi
            //int sayi = 255;
            //string binary = Convert.ToString(sayi, 2);
            //string binary8 = Convert.ToString(sayi, 8);
            //string binary16 = Convert.ToString(sayi, 16);
            //Console.WriteLine(binary);
            //Console.WriteLine(binary8);
            //Console.WriteLine(binary16);
            #endregion

            #endregion


            #region DateTime Metodlari
            // Bulundugunuz ani veren metod 
            //Console.WriteLine(DateTime.Now);

            //// Bulundugunuz ani veren metod 0. Meridyenin zamanini verir 
            //Console.WriteLine(DateTime.UtcNow);
            // Artik yil kontrolu 
            //Console.WriteLine(DateTime.IsLeapYear(2000));
            //Console.WriteLine(DateTime.IsLeapYear(2001));
            ////Haftanin gunu
            //Console.WriteLine(DateTime.Now.DayOfWeek);
            ////Yilin kacinci  gunu
            //Console.WriteLine(DateTime.Now.DayOfYear);


            // Yeni bir tarih olusturmak icin 

            //DateTime yeniTarih = new DateTime(2000, 12, 24);
            //Console.WriteLine(yeniTarih);

            #region Tarihin Ekrana Bastirilmasi
            // Ekrana Bastirilmasi  
            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.ToString("MM.dd.yyyy")); //12.24.2023
            //Console.WriteLine(dt.ToString("dddd,dd MMMM yyyy HH:mm")); //Pazar,24 Aralık 2023 09:28
            //Console.WriteLine(dt.ToString("dddd,dd MMMM yyyy HH:mm tt")); //Pazar,24 Aralık 2023 09:29 ÖÖ
            //Console.WriteLine(dt.ToString("yyyy-MM-dd"));//2023-12-24
            //Console.WriteLine(dt.ToString("yyyy-MMMM-dddd"));
            //DateTime date = new DateTime(2023, 1, 1);
            //for (int i = 0; i < 12; i++)
            //{
            //    Console.WriteLine(date.AddMonths(i).ToString("MMMM"));
            //}
            #endregion
            #endregion

        }
    }
}
