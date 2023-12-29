namespace _19_DosyaIslemleriVeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> UrunIdleri = new List<int>();
            List<string> UrunIsimleri = new List<string>();
            List<int> Kategoriler = new List<int>();
            List<int> Tedarikciler = new List<int>();
            List<string> AdetIcerigi = new List<string>();
            List<double> Fiyatlar = new List<double>();
            List<int> StokAdedi = new List<int>();
            List<int> SiparisAdedi = new List<int>();
            List<int> ReOrders = new List<int>();
            List<bool> discontinued = new List<bool>();


            var products = File.ReadAllLines("Products.csv");

            foreach (var urun in products)
            {


                var satir = urun.Split(';');
                UrunIdleri.Add(int.Parse(satir[0]));
                UrunIsimleri.Add(satir[1]);
                Tedarikciler.Add(int.Parse(satir[2]));
                Kategoriler.Add(int.Parse(satir[3]));
                AdetIcerigi.Add(satir[4]);
                Fiyatlar.Add(double.Parse(satir[5]));
                StokAdedi.Add(int.Parse(satir[6]));
                SiparisAdedi.Add(int.Parse(satir[7]));
                ReOrders.Add(int.Parse(satir[8]));
                discontinued.Add(satir[9] == "0" ? true : false);

                Console.WriteLine(urun);
            }

            List<string> insertCumleleri = new List<string>();


            for (int i = 0; i < UrunIsimleri.Count; i++)
            {
                string sql = $@"INSERT INTO [Products]
                               ([ProductName]
                               ,[SupplierID]
                               ,[CategoryID]
                               ,[QuantityPerUnit]
                               ,[UnitPrice]
                               ,[UnitsInStock]
                               ,[UnitsOnOrder]
                               ,[ReorderLevel]
                               ,[Discontinued])
                         VALUES ('{UrunIsimleri[i]}' 
                                    ,{Tedarikciler[i]} 
                                    ,{Kategoriler[i]} 
                                    ,'{AdetIcerigi[i]}'
                                    ,{Fiyatlar[i]}
                                    ,{StokAdedi[i]}
                                    ,{SiparisAdedi[i]}
                                    ,{ReOrders[i]}
                                    ,{(discontinued[i] == false ? 1 : 0)})";

                insertCumleleri.Add(sql);
            }


        }
    }
}
