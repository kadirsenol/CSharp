namespace _14_MyLibrary
{
    public static class StringIslemleri
    {

        public static int CumleSayisi(string paragraf)
        {
            int cumleSayisi = 0;
            if (string.IsNullOrEmpty(paragraf))
            {
                return 0;
            }

            var sonuc = paragraf.Split('.');
            return sonuc.Length;

            // return paragraf.Split('.').Length;

        }

        public static int KelimeSayisi(string paragraf)
        {

            if (string.IsNullOrEmpty(paragraf)) return 0;

            return paragraf.Split(' ').Length;


        }
        public static bool Sansur(List<string> yasaklikelimeler, string paragraf)
        {

            foreach (var item in yasaklikelimeler)
            {
                if (paragraf.ToLower().Contains(item.ToLower()))
                    return true;
            }

            return false;
        }
    }
}
