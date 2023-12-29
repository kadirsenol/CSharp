namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Degisken tanimlarken once tipini bildirmek gerekir.
            // int sayi yada float numericSayi v.b..
            // Region Kisa yolu ctrl+k+s
            #region Degisken Isimlendirme Kurallar
            /*
                * Değişken adı bir harfle başlamalıdır.
                   Değişken adı yalnızca harf, rakam ve alt çizgi (_) içerebilir.
                   Değişken adları büyük-küçük harf duyarlıdır.
                   Özel bir anlamı olan anahtar kelimeler kullanılamaz.
                *  Birlesik Kelimeler olursa PascalCase Kullanilmasi Tavsiye edilir.
                *  Türkçe karakter kullanmaniza izin versede tavsiye edilmez
                * Bir değişkene verilen x, y, z isimleri ileriki zamanlarda tekrar bakıldığında ya da farklı bir yazılımcı tarafından bakıldığında x, y, z’nin neye denk geldiğini anlayabilmesi için kodun en başına gidip kontrol etmesi gerekir.
                */
            #endregion

            #region Hatali kullanim Ornekleri
            //char a = 'AAAAA'; //Bu kullanim Yanlistir
            //char 1a = 'B'; // Buda yanlistir
            //DateTime $dateTime = DateTime.Now; //Yanlis 

            //Secilen alani yorum satirina almak icin kisa yol ctrl+k+c
            //Secilen alani yorum satirindan cikarmak icin kisa yol ctrl+k+u 
            #endregion

            DateTime _dateTime = DateTime.Now; // Dogru bir kullanim


            #region Sayisal Degiskenler

            //int sayi; // ilk deger atanmasi yapilmamis degisken
            //int yas = 0; // ilk deger atamasi yapilmis degisken 4 byte
            //byte Yas = 0; // 255 'e kadar atama yapilabilir
            //double dortalama = 22 / 7.0; // Ondalikli sayi icin 8 byte
            //float fortalama = 22 / 7.0f;   // 4 byte
            //decimal decimalOrtalama = 22 / (decimal)7.0; // 12 byte
            //char a = 'a';
            //Console.WriteLine("Float Ortalama:" + fortalama);
            //Console.WriteLine("double Ortalama:" + dortalama);
            //Console.WriteLine("Decimal Ortalama:" + decimalOrtalama);

            //Yas = 255;

            #endregion


            // String bir karakter dizisidir. Memory'de heap alaninda tutulur. Cunku string ifadenin ne kadar uzun oldugu belli degildir.


            #region String Degisken
            //string cumle = "Bugun hava yagmurlu";
            //// string ifadeleri aslinda char dizisidir
            ////for (int i = 0; i < cumle.Length; i++)
            ////{
            ////    Console.WriteLine(cumle[i]);
            ////}
            //string haber = "CHP Genel Başkanı Özgür Özel, TBMM'de grup oluşturabilmesi için bütçe görüşmeleri boyunca Kütahya Milletvekili Ali Fazıl Kasap'ın Saadet Partisi'nde görev yapacağını belirterek, \"Saadet Partisi sözünü söyleyemez hale gelirse bu demokrasi açısından da çok ayıp. Hele hele Hasan Bitmez'in son nefesine kadar kürsüde sözünü söylemeye çalışan gayretini de göz önüne getirilince kendisinin hatırasına da saygısızlık olur.\" dedi.\r\n\r\nManisa'da düzenlenen CHP Gençlik Kolları İl Başkanları Toplantısı için kente gelen katılımcılara şehri gezdiren Özel, Tarihi Sultan Camisi Külliyesi ziyareti sırasında bir gazetecinin Saadet Partisi Kocaeli Milletvekili Hasan Bitmez'in vefatı sonrası Saadet Partisi'nin TBMM'de grup kurma çoğunluğunu kaybettiğini belirterek, konuyla ilgili CHP'nin bir kararı olup olmadığı yönündeki sorusunu yanıtladı.";


            //Console.WriteLine(haber);
            #endregion

            #region Tarih Desiskenleri

            //DateTime dogumTarihi = DateTime.Now;
            //Console.WriteLine(dogumTarihi);

            //DateOnly dateOnly = new DateOnly();
            //Console.WriteLine(dateOnly);

            //TimeOnly timeOnly = new TimeOnly();
            //Console.WriteLine(timeOnly);

            #endregion
            //Console.WriteLine("Hello, World!");


            #region Const
            // Const : Sabit Demek
            //Tanimlandiginda deger atamasi yapilabilir.
            // Bir daha da yapilmaz
            const double pi = 3.14;
            const string ProgramAdi = "Version 2.0";
            #endregion
            #region Escape Karakterler
            // Escape Karakterler
            // \n => yeni satir
            // \t => tab yerine gecer
            // \b   backspace
            // \f	Form feed
            // \r Carriage return
            // \"
            // Benim Adim "Ercan" ifadesini bastirmak

            string str = "benim adim \t  \" Ercan \" \n Burasi yeni bir satirdir";

            Console.WriteLine(str);
            int yas = 20;
            str = @"Bugun gunlerden pazar.
                    Ve Hava cok guzel
                    ";

            Console.WriteLine(str);
            str = @$"Benim yasim {yas} dir .
qwesdlkfsjdf  ";
            Console.WriteLine(str);
            #endregion



            //System.Double d = 12.5;
            //double dd = 10;

            //Int32 sayi = 12;
            //int Sayi = 12;


            #region  Bir siniftaki ogrencilerin bilgilerini tutacak degiskenleri tanimlayiniz.
            // Ad,Soyad,DogumTarihi , Cinsiyet , TcNo

            //string ad, soyad = "Kaya"; // Aralarina virgul konularak degisken tanimlayablirsiniz
            //DateOnly DogumTarihi = new DateOnly(2000, 1, 1);
            //char cinsiyet = 'E';
            //string strCinsiyet;
            //bool Cinsiyet = true;
            //ad = "Ali";
            //string tcno = "12345678901";
            //Console.WriteLine(ad + " " + soyad + " " + Cinsiyet + " " + DogumTarihi + " " + tcno);

            //Console.WriteLine($"{ad} {soyad}  {Cinsiyet} {DogumTarihi} {tcno}");
            //Console.WriteLine("{0} {1} {2}", ad, soyad, Cinsiyet);
            #endregion
        }
    }
}
