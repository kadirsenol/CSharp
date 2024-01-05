using Microsoft.Data.SqlClient;
namespace _20_DosyaOkumaVeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> idler = new List<int>();
            List<string> filmler = new List<string>();
            List<string> aciklamalar = new List<string>();
            List<int> sureler = new List<int>();

            List<string> cumleler = new List<string>();


            var filmler2 = File.ReadAllLines(@"..\..\..\Filmler.csv");
            var index = 0;

            foreach (var film in filmler2)
            {
                if (index == 0)
                {

                    string str = @"Create Table Filmler (
	                                [Id] [int] IDENTITY(1,1) NOT NULL,
	                                [FilmAdi] [varchar](50) NULL,
	                                [Aciklama] [varchar](max) NULL,
	                                [Sure] [tinyint] NULL,
                                 CONSTRAINT [PK_Filmler] PRIMARY KEY CLUSTERED 
                                (
	                                [Id] ASC
                                ))";
                    cumleler.Add(str);
                    index++;
                    continue;
                }
                else
                {

                    var satir = film.Split(';');

                    try
                    {
                        idler.Add(int.Parse(satir[0]));
                        filmler.Add(satir[1].Replace("\"", ""));
                        aciklamalar.Add(satir[2].Replace("\"", ""));
                        sureler.Add(int.Parse(satir[3]));
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"Hata Olustu.Satir {index}:" + ex.Message);
                    }
                    //idler.Add(int.Parse(film.Split(';')[0]));


                }
                index++;
            }

            for (int i = 0; i < idler.Count; i++)
            {
                string sql = $@"Insert into Filmler (FilmAdi,Aciklama,Sure) 
                Values('{filmler[i]}' , '{aciklamalar[i]}',{sureler[i]})";
                cumleler.Add(sql);
            }




            foreach (var item in cumleler)
            {
                SorguCalistir(item);
            }
        }

        public static int SorguCalistir(string sql)
        {


            string connstr = "Server=.;Database=test;Trusted_Connection=true;trust server certificate=true";

            SqlConnection conn = new SqlConnection(connstr);
            int result = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Beklenmeyen bir hata olustu :" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;




            return 0;
        }

    }
}


