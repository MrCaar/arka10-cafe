public static class PublicKodlar
{
    public static List<string> BahceMasalari = new List<string> { };
    public static List<string> TerasMasalari = new List<string> { };
    public static List<string> SalonMasalari = new List<string> { };
    public static string selectedTable = null;
    public static string mySQLServer = "127.0.0.1";
    public static string mySQLDatabase = "arka10";
    public static string mySQLUsername = "root";
    public static string mySQLPassword = "";

    public static void MasaEkle(string alan, List<string> masalar)
    {
        int yeniNumara = masalar.Count + 1;
        string yeniMasa = alan + yeniNumara;
        masalar.Add(yeniMasa);
    }

    //public static List<string> GetirMasalar(List<string> masalar)
    //{
    //    return masalar;
    //}

    // Masa silme
    public static void MasaSil(List<string> masalar)
    {
        if (masalar.Count > 0)
        {
            masalar.RemoveAt(masalar.Count - 1); // Son elemanı sil
        }
    }
}
