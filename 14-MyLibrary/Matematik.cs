namespace _14_MyLibrary
{
    /*
     *  Odev
     * Girilen iki sayinin karesini alan metod
     * Girilen iki sayinin küpünü alan metod
     * ekrandan girilen sayiya kadar ki fibanocci sayilari basiniz
     * 
     * 
     * 
     */


    public static class Matematik
    {
        /*
        * double geri donecek sekilde SayiOku metodu
        * belirsiz sayidaki parametleri toplayacak metod
        * Faktoryel hesabi yapacak metod
        * 
        * Asal sayi olup olmadigini kontrol eden metod
        * 
        * 
        */
        public static int SayiOku(string mesaj)
        {
            int sayi = 0;
            string okutulan = "";

            bool flag = false;
            //sayi = int.Parse(okutulan);
            while (true)
            {
                Console.Write(mesaj);
                okutulan = Console.ReadLine();
                try
                {
                    sayi = int.Parse(okutulan);
                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Sayisal  deger giriniz:");


                }
                catch (OverflowException ofex)
                {
                    Console.WriteLine("Daha Kucuk sayi giriniz:");

                }
            }
            Console.Clear();
            return sayi;
        }


        public static decimal DecimalSayiOku(string mesaj)
        {
            decimal sayi = 0;
            string okutulan = "";


            while (true)
            {
                Console.Write(mesaj);
                okutulan = Console.ReadLine();
                try
                {
                    sayi = decimal.Parse(okutulan);
                    break;
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Sayisal  deger giriniz:");


                }
                catch (OverflowException ofex)
                {
                    Console.WriteLine("Daha Kucuk sayi giriniz:");

                }
            }
            Console.Clear();
            return sayi;
        }


        public static decimal Faktoryel(string mesaj)
        {
            int sayi = SayiOku(mesaj);
            decimal faktoryel = 1;

            for (int i = 1; i <= sayi; i++)
            {
                faktoryel *= i;
            }
            return faktoryel;
        }

        /// <summary>
        /// Ekrandan alinan sayinin Asal olup olmadigini belirler
        /// </summary>
        /// <param name="mesaj">Ekrana verilecek mesaj</param>
        /// <returns>True / False </returns>
        public static bool Asalmi(string mesaj)
        {
            /*
             * Asal Sayi Tanimi: 1'den buyuk , kendisinden ve 1 den baska
             * boleni olamayan sayilara asal sayi denir.
             * 
             */
            bool result = false;
            int sayi = SayiOku(mesaj);
            int sayac = 0;
            if (sayi < 2)
            {
                return false;
            }

            for (int i = 2; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                }
                if (sayac > 2)
                {
                    return false;
                }
            }

            return true;
        }


        /// <summary>
        ///  Ekrandan iki okur ve karesini ekrana basar
        /// </summary>
        public static void IkiSayininKaresi()
        {
            int sayi1 = SayiOku("Birinci Sayiyi Giriniz:");
            int sayi2 = SayiOku("Ikinci  Sayiyi Giriniz:");

            Console.WriteLine($"Birinci Sayinin Karesi :{Math.Pow(sayi1, 2)}");
            Console.WriteLine($"Ikinci Sayinin Karesi :{Math.Pow(sayi2, 2)}");


        }

    }


}
