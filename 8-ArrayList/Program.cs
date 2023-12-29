using System.Collections;

namespace _8_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList object turunden deger kabul ettigi icin 
            // icerisine herhangi bir sey atabilirsiniz.
            // Boş bir cuval olarak dusunulebilir.
            // Icerisine her turlu deger atanabilir


            ArrayList dizi = new ArrayList();

            // Listeye eleman ekleme 
            dizi.Add(12);
            #region Object kavrami
            // Object turu c# dilinde butun veri tiplerinin atasidir.
            // Herturlu degisken atanabilir
            object obj, obj2, obj3, obj4 = new object();

            obj = 43;
            obj = DateTime.Now;// Yukarida int atanmis olan degiskene simdi ise tarih atayabiliyoruz
            obj2 = 12;
            obj3 = "Ali Veli";
            obj4 = true;
            #endregion

            //ArrayListe Eleman Ekleme
            dizi.Add(obj);
            dizi.Add(obj2);
            dizi.Add(obj3);
            dizi.Add(obj4);
            #region Elemanlari Listeleme

            // 1. Yol Normal Dongu ile 
            //for (int i = 0; i < dizi.Count; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            int a, b, c;
            DateTime trh;

            foreach (var item in dizi)
            {

                if (item.GetType() == typeof(int))
                {
                    a = int.Parse(item.ToString()); // ToString() metodu object'ten gelir. VE objenin icerisindeki degeri string olarak size verir
                }
                if (item.GetType() == typeof(DateTime))
                {
                    trh = DateTime.Parse(item.ToString());
                }
                Console.WriteLine(item);
                Console.WriteLine(item.GetType());
            }

            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
