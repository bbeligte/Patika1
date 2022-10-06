internal class Program
{
    private static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan("Gordon", "Freeman", 27, "Theoretical physicist");
        calisan1.CalisanYazdir();

        Calisan calisan2 = new Calisan("Adam", "Jensen", 29, "Chief of Security");
        calisan2.CalisanYazdir();
    }
}

class Calisan
{
    public string isim;
    public string soyIsim;
    public int no;
    public string departman;

    public Calisan(string Isim, string SoyIsim, int No, string Departman)
    {
        isim = Isim;
        soyIsim = SoyIsim;
        no = No;
        departman = Departman;
    }

    public void CalisanYazdir()
    {
        Console.WriteLine("***Çalışan bilgileri yazdırılıyor***");
        Console.WriteLine("Çalışanın adı: {0}", isim);
        Console.WriteLine("Çalışanın soyadı: {0}", soyIsim);
        Console.WriteLine("Çalışanın numarası: {0}", no);
        Console.WriteLine("Çalışanın departmanı: {0}", departman);
        Console.WriteLine("");
    }
}