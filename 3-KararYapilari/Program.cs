namespace KararYapilari
{
    internal class Program
    {
        // Karar Yapilari : if => programin akisini duruma gore degistirmeye yarar
        // 3 adet karar yapisi vardir
        // 1- if-else 
        // 2- switch-case
        // 3- ternary if

        /*
                Karşılaştirma operatorleri
            1) == Karsilikli iki degiskenin birbiriyle esit olmasi durumu
            2) != Karsilikli iki degiskenin birbiriyle esit olmamasi durumu
            3) <  soldaki degerin sagdaki degerden kucuk olma durumu
            4) >  soldaki degerin sagdaki degerden buyuk olma durumu
            5) <= ve >= ifadeleri ise soldaki degirin sagdaki degerle buyuk esit yada kucuk esit durumu kiyaslar
         */

        static void Main(string[] args)
        {
            #region If-Else
            // Ekrandan bir kullanic kodu ve sifre isteyelim
            //eger admin ,sifre 1234 girildi ise  hosgeldin admin
            // degilse  Kullanici Bilgileriniz yanlistir mesaji verdirelim
            //string username, password;

            //Console.Write("Kullanici Kodunu giriniz:");
            //username = Console.ReadLine();
            //Console.Write("Password giriniz:");
            //password = Console.ReadLine();


            //if (username == null || password == null)
            //{
            //    Console.WriteLine("Duzgun veri giriniz");
            //}
            //if (username.Length <= 3 || password.Length <= 3)
            //{
            //    Console.WriteLine("En az 4 karakter girisi yapiniz..");
            //    return;
            //}


            //if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            //{
            //    Console.WriteLine("Boş deger girmeyiniz..");
            //}
            //if (username == "admin" && password == "1234")
            //{
            //    Console.WriteLine("Hosgeldin admin...");
            //}

            #endregion


            #region Birden fazla durum icin 
            // Haftanin kacinci gunu oldugunu isteyelim. Ve gun yazdirilam.
            string gun;
            //Console.Write("Haftanin Gununu giriniz:");
            //gun = Console.ReadLine();

            //if (gun == "1")
            //{
            //    Console.WriteLine("Pazartesi");
            //}
            //else if (gun == "2")
            //{
            //    Console.WriteLine("Sali");
            //}
            //else if (gun == "3")
            //{
            //    Console.WriteLine("Carsamaba");
            //}
            //else if (gun == "4")
            //{
            //    Console.WriteLine("Persembe");
            //}
            //else if (gun == "5")
            //{
            //    Console.WriteLine("Cuma");
            //}
            //else if (gun == "6")
            //{
            //    Console.WriteLine("Cumartesi");
            //}
            //else if (gun == "7")
            //{
            //    Console.WriteLine("Pazar");
            //}

            #endregion


            #region Sorular
            // Kullanicidan alinan sayinin tek mi cift mi oldugunu yazdirin
            string input;
            int sayi = 0;
            //Console.Write("Bir sayi giriniz:");
            //input = Console.ReadLine();
            //sayi = int.Parse(input); // string ifadeyi integer'a cevirmeye yarar
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayi Cifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Tektir");
            //}

            // Ekrandan alinan suyun sicakligi  okutun ve durumunu yazdirin
            //Console.WriteLine("Suyun sicakligini giriniz:");
            //input = Console.ReadLine();
            //sayi = int.Parse(input);
            //if (sayi < 0)
            //{
            //    Console.WriteLine("Su kati haldedir");
            //}
            //else if (sayi > 0 && sayi < 100)
            //{
            //    Console.WriteLine("Sivi haldedir");
            //}
            //else
            //{
            //    Console.WriteLine("Gaz halindedir");
            //}
            #endregion

            #region Soru 4
            /* Girilen Not 0-30 arasinda ise FF
             * 30-50 araligi DD
             * 50-70 arasi BB
             * 70-100 arasi AA
             * Olacak sekilde kullaniciyi bilgilendirin.
             */
            //Console.WriteLine("Not giriniz");
            //input = Console.ReadLine();
            ////sayi = int.Parse(Console.ReadLine());
            ////
            //sayi = int.Parse(input);
            //if (sayi <= 30)
            //{
            //    Console.WriteLine("FF");
            //}
            //else if (sayi > 30 && sayi < 50)
            //{
            //    Console.WriteLine("DD");
            //}
            //else if (sayi >= 50 && sayi < 70)
            //{
            //    Console.WriteLine("BB");
            //}
            //else
            //{
            //    Console.WriteLine("AA");
            //}
            #endregion

            #region Soru 5
            /*
            Disaridan urun adi girilecek 
            program urunun hangi reyonda oldugunu soyleyecek
            Domates,biber,patlican icin Sebze Reyonu
            Diş mancunu ,Parfum,Krem icin Kozmetik reyonu
            Telefon,Bilgisayar ,Ses sistemleri icin Teknoloji reyonu 
            Bunlardan farkli  bir urun girer ise "Bu urun bizde yok " uyarisi verecek
            */

            //Console.WriteLine("Urun Adi Giriniz:");
            //input = Console.ReadLine();
            //if (input == "Domates" || input == "biber" || input == "Patlican")
            //{
            //    Console.WriteLine("Manav Reyonu");
            //}
            //else if (input == "Diş mancunu" || input == "Parfum" || input == "Krem")
            //{
            //    Console.WriteLine("Kozmetik");
            //}
            //else if (input == "Telefon" || input == "Bilgisayar" || input == "Ses sistemleri")
            //{
            //    Console.WriteLine("Teknoloji");
            //}
            //else
            //{
            //    Console.WriteLine("Bu urun bizde tanimli degil");
            //}
            #endregion

            #region Soru 6
            /*
            Urun fiyati:5 Tl olsun
            Disaridan girilecek siparis sayisina gore
            20 de az ise toplam ucretten % 5 indirim yapilacak
            20 - 50 arasinda ise % 10 indirim
            50 - 100 arasinda ise % 15 indirim
            100 ve uzeri icin % 20 indirim yapilsin
            Ekrana Toplam tutar ,indirim miktari ve Odenecek tutar bilgilerini yazdirin
            */
            //int adet = 0, fiyat = 5;
            //float indirim = 0, odenecekTutar = 0;

            //Console.WriteLine("Siparis Adedini giriniz:");
            //adet = int.Parse(Console.ReadLine());
            //if (adet < 20)
            //{
            //    indirim = adet * fiyat * 0.05f;
            //    odenecekTutar = adet * fiyat - indirim;
            //    Console.WriteLine($"Toplam Tutar {adet * fiyat} , indirim : {indirim}  odenecek tutar:{odenecekTutar}");

            //}
            //else if (adet >= 20 && adet < 50)
            //{
            //    indirim = adet * fiyat * 0.1f;
            //    odenecekTutar = adet * fiyat - indirim;
            //    Console.WriteLine($"Toplam Tutar {adet * fiyat} , indirim : {indirim}  odenecek tutar:{odenecekTutar}");
            //}
            //else if (adet >= 50 && adet < 100)
            //{
            //    indirim = adet * fiyat * 0.15f;
            //    odenecekTutar = adet * fiyat - indirim;
            //    Console.WriteLine($"Toplam Tutar {adet * fiyat} , indirim : {indirim}  odenecek tutar:{odenecekTutar}");
            //}
            //else
            //{
            //    indirim = adet * fiyat * 0.2f;
            //    odenecekTutar = adet * fiyat - indirim;
            //    Console.WriteLine($"Toplam Tutar {adet * fiyat} , indirim : {indirim}  odenecek tutar:{odenecekTutar}");
            //}
            #endregion

            #region Ternary IF
            // Eger Tek satirda ufak bir kara mekanizmasi ile yolumuza devam etmek istersek
            // soru isareti operatoru size bu konuda yardimci olacakti.Yazim formati
            //  sonuc> 10 ? "True oldunda calisacak kod" : "False oldugunda calisacak kod

            int? yas; // Buradaki ? isareti degiskenin null degerler alabilecegini gosterir.
            yas = 20;

            Console.WriteLine(yas);

            var test = "ali";
            var test2 = 12;
            var test3 = DateTime.Now;

            var result = yas > 18 ? "resit" : "resit degildir ";
            Console.WriteLine(result);
            #endregion

            #region Switch case
            /*
            if-else mantigi ile calisir.Aradaki fark 
            if-else buyukluk , kucukluk gibi durumlari kontrol ederken ,
            switch-case yanlizca esitlik durumlarini kontrol eder.
            Kendisine ait bir indexleme mekanizmasi vardir.
           Siraya koyar otomatik olarak yuzlerce kosulumuz olsa bile herbirine bakmadan
           hangisine esit ise oraya konumlanir.

           switch icerisindeki veri tipiniz ne ise case de de ayni veri tipi olmalidir
            */

            //string mevsim = "", mesaj = "";
            //Console.WriteLine("Mevsim Giriniz:");
            //mevsim = Console.ReadLine();
            //switch (mevsim)
            //{
            //    case "Kış":
            //        mesaj = "Aralik,Ocak,Subat";
            //        break;
            //    case "ilk bahar":
            //        mesaj = "Mart,Nisan,Mayis";
            //        break;
            //    case "Yaz":
            //        mesaj = "Haziran,Temmuz,Agustos";
            //        break;
            //    case "Son Bahar":
            //        mesaj = "Eylul,Ekim,Kasim";
            //        break;
            //    default:// Ongörülen bir durum harici degerle karşılaşırsak,
            //            //        //varsayilan olarak buraya girer.
            //        mesaj = "Boyle bir tanimlama yok";
            //        break;
            //}

            //if (mevsim == "Kis")
            //{
            //    mesaj = "Aralik,Ocak,Subat";
            //}
            //else if (mevsim == "ilk bahar")
            //{
            //    mesaj = "Mart,Nisan,Mayis";

            //}
            //else if (mevsim == "Yaz")
            //{
            //    mesaj = "Haziran,Temmuz,Agustos";

            //}
            //else if (mevsim == "son bahar")
            //{
            //    mesaj = "Eylul,Ekim,Kasim";

            //}
            //else
            //{
            //    mesaj = "Boyle bir tanimlama yok";
            //}



            //Console.WriteLine(mesaj);
            #endregion

            #region Switch-Case Soru
            // Ekrandan rol okutalim.
            // Eger Admin girilirse ekrana "admin sayfasina yonlendiriliyorsunuz " mesaji versin
            // Eger Satis "Satis sayfasina "
            // Eger Uye girisi yaparsa "Uye sayfasina yonlendiriliyorsunuz" diye mesaj verin. 

            //Console.WriteLine("Rolu Giriniz");
            //string? rol = Console.ReadLine();
            //switch (rol)
            //{
            //    case "Moderator":
            //    case "CEO":
            //    case "Admin":
            //        Console.WriteLine("Admin sayfasina yonlendiriliyorsunuz...");
            //        break;
            //    case "Satis":
            //        Console.WriteLine("Satis sayfasina yonlendiriliyorsunuz...");
            //        break;
            //    case "Uye":
            //        Console.WriteLine("Uye sayfasina yonlendiriliyorsunuz...");
            //        break;
            //    default:
            //        break;
            //}


            #endregion

            #region Soru 2
            /*
           Ekrandan ay okutun ornegin 1 girilirse Ocak 2 girilirse Subat ...12 girilirse Aralik yazsin
           */

            #endregion
            #region Soru 3
            //Kullanici adi ve sifre aliniz 
            //kullanici ad ve sifre dogru ise "tebrikler ,hem kullanici ad hemde sifre dogru "
            //Kullanici adi dogru sifre yanliş ise "Kullanici adiniz dogru ancak sifre yanliş"
            //kullanici adi yanliş şifre dogru ise "Kullanici adiniz yanliş ancak sifre dogru"
            //mesajını veriniz.

            //Console.WriteLine("User Name");
            //string? username = Console.ReadLine();

            //Console.WriteLine("Password");
            //string? password = Console.ReadLine();

            //switch (username)
            //{
            //    case "admin":
            //        switch (password)
            //        {
            //            case "123":
            //                Console.WriteLine("Tebrikler kullanici adi ve sifre dogru");
            //                break;
            //            default:
            //                Console.WriteLine("Kullanic Adi Dogru ancak sifre yanliş");
            //                break;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Kullanici adiniz yanliş . Sifreye bakmadim bile bu cuma aksami");
            //        break;
            //}

            // Deneme
            // sdfşklsdşlkfsdklş
            #endregion

            #region Ternary If Ornek
            string tel = "5437776655", gsm = "";
            if (tel.Length >= 10)
            {
                gsm = tel;
            }
            // Yukaridaki kodun yerine daha kisa olarak asagidaki kod yazilabliir
            gsm = tel.Length >= 10 ? tel : "";
            #endregion

        }

    }
}

