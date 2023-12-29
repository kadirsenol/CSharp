using System.Collections;

namespace _17_GenelTekrarHazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ++ ve -- operatorleri
            //int a, b, c, d, e;
            //a = 5;
            //b = a++; // Once atamam yapilir sonra a bir artirilir
            //Console.WriteLine($" a  :{a} , b : {b}");

            //c = ++a; // Once a'nin degerini arttirir sonra atama yapilir
            //Console.WriteLine($" c :{c} ,a : {a}");

            //d = --a; // Once a degeri bir azaltilir sonra atama yapilir


            //Console.WriteLine($" d  :{d} , a : {a}");

            //e = a--; // Once atamam yapilir sonra a degeri bir azaltilir
            //Console.WriteLine($" e :{e} , a : {a}");
            //a = 1;
            //b = 1;
            //e = b + ++a;
            //e = --b - --a; // 0 degeri alir
            //e = b++ - ++a; // -1 degeri alir

            //Console.WriteLine($" e :{e} , a : {a} , b:{b}"); 
            #endregion

            #region Math hazir metodlari
            //Birinci parametrede verilen sayinin ikici parametre verilen ustunu alir
            //Console.WriteLine(Math.Pow(2, 3));

            //// Karekok alma 

            //Console.WriteLine(Math.Sqrt(81));

            //Küp kök alma
            //Console.WriteLine(Math.Pow(27, 1 / (double)3));
            //Console.WriteLine(Math.Pow(27, 0.3333333f));
            //Console.WriteLine(Math.Pow(27, 0.333333));


            #region Yuvarlama 
            //Floor => Verilen ondalikli sayiyi bir alta yuvarlar
            #region Floor
            //double d = 11.3;
            //Console.WriteLine(Math.Floor(d));
            //d = 11.6;
            //Console.WriteLine(Math.Floor(d)); 
            #endregion

            //Ceiling => Verilen ondalikli sayiyi bir uste yuvarlar
            #region Ceiling
            //Console.WriteLine(Math.Ceiling(d));
            //d = 11.5;
            //Console.WriteLine(Math.Ceiling(d));
            //d = 11.3;
            //Console.WriteLine(Math.Ceiling(d)); 
            #endregion

            //Round => Verilen ondalikli sayiyi yaridan fazlasini bir uste yuvarlar,yaridan azini bir alta yuvarlar

            #region Round 
            //Console.WriteLine("********* Round *************");
            //Console.WriteLine(Math.Round(10.4)); //10
            //Console.WriteLine(Math.Round(10.6)); //11
            //Console.WriteLine(Math.Round(10.5)); //11 
            //Console.WriteLine(Math.Round(11.5)); //12
            //Console.WriteLine(Math.Round(12.5)); //11
            //Console.WriteLine(Math.Round(13.5)); //14 
            #endregion

            #endregion

            #endregion

            #region DateTime Hazir Metodlar (Build in metodlar)
            //Console.WriteLine(DateTime.Now); // Simdiki ani verir. Yani tarih ve zaman vardir
            //Console.WriteLine(DateTime.Now.ToShortTimeString());
            //Console.WriteLine(DateTime.Now.ToLongTimeString());
            //Console.WriteLine(DateTime.Now.ToLongDateString());
            //Console.WriteLine(DateTime.Now.ToShortDateString());
            //Console.WriteLine(DateTime.Today);
            //#endregion
            //TimeSpan timeSpan;

            //DateTime dogumGunu = new DateTime(1997, 8, 6);
            //timeSpan = DateTime.Now - dogumGunu;
            //Console.WriteLine($"Mina {timeSpan.Days} gundur , {timeSpan.TotalDays} ,hayatta");

            //// bulundugum gunden 10 gun sonrasi 
            //DateTime tarih = DateTime.Now.AddDays(10);
            //// bulundugum gunden 10 gun Oncesi
            //DateTime tarih2 = DateTime.Now.AddDays(-10);

            //// Ay basini bulma
            //DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //Console.WriteLine(date);
            #endregion

            #region String Hazir Metodlari

            string haber = "       Çalışma ve Sosyal Güvenlik Bakanı Vedat Işıkhan, yeni yılda geçerli olacak asgari ücreti açıkladı. 1 Ocak 2024'ten itibaren asgari ücret 17 bin 2 lira olacak. Bu rakamın 700 lirası asgari ücret desteği olarak belirlendi.       ";

            #region Split

            var cumleler = haber.Split('.');
            //for (int i = 0; i < cumlesaysi.Length; i++)
            //{
            //    Console.WriteLine(cumlesaysi[i]);
            //}
            //int kelimesayisi = 0;
            //foreach (var cumle in cumleler)
            //{
            //    Console.WriteLine(cumle);
            //    var kelimeler = cumle.Split(",");
            //    for (int i = 0; i < kelimeler.Length; i++)
            //    {
            //        var kelime = kelimeler[i].Split(' ');
            //        foreach (var item in kelime)
            //        {
            //            var str = item.Split('\'');
            //            if (str.Length > 1)
            //            {
            //                foreach (var item1 in str)
            //                {
            //                    Console.WriteLine(item1);
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine(item);
            //            }

            //        }

            //    }
            //}
            #endregion
            #region Bosluklari Alma

            //Console.WriteLine(haber.TrimStart()); // Baştaki Boşluklari Atar
            //Console.WriteLine(haber.TrimEnd()); //  Sondaki boşluklari Atar
            //Console.WriteLine(haber.Trim()); //Baştaki Ve sondaki bopsluklari atar
            //Console.WriteLine(haber.Contains("Ocak")); // true 
            //Console.WriteLine(haber.StartsWith("Ocak")); // False
            //Console.WriteLine(haber.Trim().Substring(7, 10));
            //// Vedat yerine Ahmet yazalim
            //Console.WriteLine(haber.Replace("Vedat", "Ahmet"));
            //var tersCumler = haber.Reverse();
            //foreach (var item in tersCumler)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #endregion

            #region Array Hazir sinifi
            int[] sayilar = { 1, 32, 13, 41, 15, 6, 76, 8, 9 };
            int[] sayilar2 = new int[10];
            Array.Sort(sayilar);//HAle Hazirdaki bir diziyi siralar
            ArrayList array = new ArrayList();
            //array.AddRange(sayilar); //Birden fazla eleman eklemeye yarar
            array.Add(sayilar);
            array.Add(DateTime.Now);
            array.Add("Ali");
            //foreach (var item in array)
            //{
            //    if (item.GetType() == typeof(int[]))
            //    {
            //        var dizi = (int[])item;
            //        foreach (var item1 in dizi)
            //        {
            //            Console.WriteLine(item1);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(item);
            //    }

            //}
            //Array.Copy(sayilar, sayilar2, 4);
            //Array.Resize(ref sayilar, 20);
            //List<int> sayilarListesi = sayilar.ToList();// List<int>


            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Listeler 

            // Listelerde tip guvenligi vardir . 

            List<object> list = new List<object>(); // ArrayList gibi davranir

            List<string> liste2 = new List<string>();
            List<DateTime> liste3 = new List<DateTime>();
            List<decimal> liste4 = new List<decimal>();
            liste2[1] = "qwe"; // Listeler dizi gibi de davranir

            #endregion
        }
    }
}
