namespace _14_MyLibrary
{
    public class Istatistik
    {
        /// <summary>
        /// Verilen sayilarin Ortalamasini Alir
        /// </summary>
        /// <param name="sayilar">istediginiz kadar integer tipinden parametre gecebilrsiniz</param>
        /// <returns>Double turunden geri donusu vardir</returns>
        public double Ortalama(params int[] sayilar)
        {
            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam / sayilar.Length;

        }
    }
}
