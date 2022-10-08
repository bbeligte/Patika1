internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

        Calisan calisan = new Calisan("Geralt", "of Rivia", "Witcher");
        Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

        Calisan calisan1 = new Calisan("Yennefer", "of Vengerberg", "Sorcerer");
        Calisan calisan2 = new Calisan("Vlodimir" , "von Everec", "Bandit");
        Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

        Console.WriteLine(Islemler.Topla(5,3));
        Console.WriteLine(Islemler.Cikar(5,3));
    }
}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string isim;
    private string soyad;
    private string departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyad, string departman)
    {
        this.isim = isim;
        this.soyad = soyad;
        this.departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static int Topla(int x, int y)
    {
        return x+y;
    }

    public static int Cikar(int x, int y)
    {
        return x-y;
    }
}