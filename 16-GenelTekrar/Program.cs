//using Bogus;

namespace _16_GenelTekrar
{
    internal class Program
    {



        static void Main(string[] args)
        {
            #region Karar Yapilari

            int a = 1, b = 2, c = 3, d = 4;// ilk deger atamali tanimlama

            //if ((b < a) && (c < d) && (d < a) || (a > b)) // Ve operatorunde Eger birisi false cikarsa digerlerine bakmaya gerek yok
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            //if ((b > a && true) || (c < d))
            //{ // Yada ifadesinde birinin true olmasi true sonucu cikartir
            //    Console.WriteLine(true);

            //}

            //var gun = DateTime.Now.DayOfWeek;
            //Console.WriteLine(gun);
            //int haftagunu = 3;
            //switch (haftagunu)
            //{
            //    case 1:
            //        Console.WriteLine("Pazar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Pazartesi");
            //        Console.WriteLine("En sevmedigim gun");
            //        if (c > a) Console.WriteLine("Buyuktur ");
            //        a = b + c;
            //        break;
            //    case 3:
            //        Console.WriteLine("Sali");
            //        break;
            //    default:
            //        Console.WriteLine("Gerisini yazmaya usendim");
            //        break;

            //}


            #endregion


            #region Donguler
            int index = 0;
            #region While Dongusu
            /*
             * 
             * Verilen şarti dongunun başında kontrol eder
             * True ise scope icerisine girer . 
             * Degilse Donguyu sonlandirir
             * 
             */

            //while (true)
            //{
            //    Console.WriteLine("Sonsuz Dongu ");
            //}


            // 1-10 arasindaki tek ve cift sayilari while ile bastiralim


            //while (index < 10)
            //{
            //    int sonuc = index % 2;
            //    string s = sonuc == 0 ? "cift" : "tek";


            //    if (sonuc == 0)
            //    {
            //        Console.WriteLine(s);
            //    }
            //    else
            //    {
            //        Console.WriteLine(s);
            //    }

            //    index++;
            //}
            //Console.WriteLine("***************************************");
            //while (index > 0)
            //{
            //    Console.WriteLine(index);
            //    index--;
            //}
            #endregion

            #region do-while
            /*
             * 
             * Do-While dongusunde kontrol her zaman sonda yapilir. Bu donguye mutlaka bir kere girilecegi anlamini tasir.
             * 
             */
            //Ekrandan 0 girilinceye kadar sayi alalim
            List<string> list = new List<string>();
            string input = "";
            int sayi;
            //do
            //{

            //    Console.WriteLine("String ifade giriniz:");
            //    input = Console.ReadLine();


            //    if (int.TryParse(input, out sayi))
            //    {
            //        Console.WriteLine("string veri giriniz");
            //        index--;
            //    }
            //    else
            //    {
            //        list.Add(input);
            //    }

            //    Console.WriteLine(index);
            //    index++;
            //} while (index < 10);
            #endregion

            #region For 

            // 1-100 arasindaki sayilardan 3 ve 5 bolunenleri bastiralim


            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //Carpim Tablosunu Basalim

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }
            //    Console.WriteLine("****************");
            //}

            //Determinant alan dongu
            #endregion

            #region For-Each
            /*
             * For each dongu degildir. Iterasyondur
             * Mutlaka bir veri setine ihtiyac duyar. 
             */

            //List<int> sayilar = new List<int>();
            //List<object> list1 = new List<object>();
            //ArrayList arrayList = new ArrayList();
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    sayilar.Add(rnd.Next(1000));
            //    arrayList.Add(rnd.Next(1000));
            //}

            //foreach (var item in sayilar)
            //{
            //    if (item % 2 == 0)
            //        Console.WriteLine(item);
            //}

            //foreach (var item in arrayList)
            //{
            //    if ((int)item % 2 == 0)
            //        Console.WriteLine(item);
            //}

            //object o1 = new object();
            //o1 = DateTime.Now;
            //Console.WriteLine(o1.GetType());
            //o1 = 43;
            //Console.WriteLine(o1.GetType());

            //o1 = "deneme";
            //Console.WriteLine(o1.GetType());

            #endregion


            #endregion
            #region try-Catch

            //a = 5;
            //b = 0;
            //c = a / b;

            //try
            //{
            //    Console.WriteLine("Bir Sayi giriniz:");
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    c = a / b;
            //}

            //catch (FormatException dex)
            //{
            //    Console.WriteLine("Duzgun veri Giriniz");
            //}
            //catch (DivideByZeroException dex)
            //{
            //    Console.WriteLine("Sifira Bolma Hatasi Olustu");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            #endregion

            #region  Sorular
            // Bir Siniftaki ogrencilerin ad soyad,tcno , dogum tarihlerini ve gsm numaralarini tutacak 
            //Listelerle yapiniz
            //List<string> adSoyad = new List<string>();
            //List<string> tcnolar = new List<string>();
            //List<DateTime> dogumTarihleri = new List<DateTime>();
            //List<string> gsmler = new List<string>();
            //a = 20;
            //b = 30;
            //Console.WriteLine(a + b.ToString()); // Biri integer digeri string olan ifadede + operatoru string birlestirmesi yapar;

            //Faker faker = new Faker();
            //for (int i = 0; i < 20; i++)
            //{
            //    adSoyad.Add(faker.Person.FirstName + " " + faker.Person.LastName);
            //    string tc = "1234567891" + i;
            //    tcnolar.Add(tc);
            //    dogumTarihleri.Add(faker.Person.DateOfBirth);
            //    gsmler.Add(faker.Person.Phone);

            //}
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write(adSoyad[i] + "\t");
            //    Console.Write(tcnolar[i] + "\t");
            //    Console.Write(dogumTarihleri[i] + "\t");
            //    Console.Write(gsmler[i] + "\t \n");


            //}

            #endregion
        }
    }
}
