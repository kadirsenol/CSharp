using System.Data.SqlClient;

namespace _7_HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Istisna Tipleri
             1- Çalişma Zamani Hatalari : Cogunlukla kullanici kaynakli hatalardir.
             2-Derleme Zamani Hatalari : Yazilimcinin yaptigi hatalardir.
             3- Mantiksal Hatalar : En zor tespit edilen hata tipidir.
             */

            // Breakpoint : Programin calisrken durmasini istedigimiz bir yer
            // olursa kullandimiz yontemdir

            // Hata yonetimi try catch mekanizmasi kullanilir
            // try => deneme
            // Cath => yakalamak

            #region Normal Kullanim
            //try
            //{
            //    int a, b, c, d;
            //    a = 3;
            //    b = 0;
            //    c = a / b;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 

            #endregion
            //byte sayi1 = 0, sayi2 = 0;
            //try
            //{
            //    Console.Write("Bir sayi Giriniz:");
            //    sayi1 = byte.Parse(Console.ReadLine());
            //    Console.Write("Ikinci sayi Giriniz:");
            //    sayi2 = byte.Parse(Console.ReadLine());
            //    Console.WriteLine($"Bolum :{sayi1 / sayi2}");
            //}
            //catch (OverflowException iex)
            //{

            //    // Console.WriteLine("0-255 arasi deger giriniz");
            //    throw new OverflowException("0-255 arasi deger giriniz");

            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine("Sayisal  deger giriniz:" + fex.Message);
            //    throw new FormatException("Sayisal  deger giriniz");

            //}
            //catch (DivideByZeroException dex)
            //{
            //    //Console.WriteLine("Sifira Bolme Hatasi");
            //    throw new DivideByZeroException("Sifira Bolme Hatasi");

            //}
            //catch (Exception ex)
            //{
            //    //throw (ex);
            //    Console.WriteLine("Bir hata olustu. Yazan kisiye danisin." + ex.Message);
            //}


            //Console.WriteLine("Hello, World!");

            //finnaly ile kullanimi
            //SqlConnection connection;
            //SqlCommand command;
            //string constr = @"Server=.;Database=Northwind;Trusted_Connection=True;";
            //connection = new SqlConnection(constr);
            //string sql = "Select * from Shippers";

            //try
            //{
            //    // Denenecek kodlar burada olmasi gerekir
            //    // Connection string
            //    connection.Open();
            //    command = connection.CreateCommand();
            //    command.CommandText = sql;
            //    SqlDataReader rdr = command.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        Console.WriteLine(rdr[0] + " " + rdr["CompanyName"] + " " + rdr["Phone"]);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //    // Hata olustugunda burasi calisacak 
            //}
            //finally
            //{
            //    // Hata olsun olmasin mutlaka calisir
            //    connection.Close();
           // }
        }
    }
}
