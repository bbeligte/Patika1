internal class Program
{
    private static void Main(string[] args)
    {
        Calisan calisan1 = new Calisan();

        calisan1.isim="Amadeus";
        calisan1.soyIsim="Mozart";
        calisan1.no=11111111;
        calisan1.departman="Musiki";

        calisan1.CalisanYazdir();

        Calisan calisan2 = new Calisan();

        calisan2.isim="Dede";
        calisan2.soyIsim="Efendi";
        calisan2.no=00000001;
        calisan2.departman="Musiki";

        calisan2.CalisanYazdir();
    }
}

class Calisan
{
    public string isim;
    public string soyIsim;
    public int no;
    public string departman;

    public void CalisanYazdir()
    {
        Console.WriteLine("***Çalışan bilgileri yazdırılıyor***");
        Console.WriteLine("Çalışanın adı: {0}", isim);
        Console.WriteLine("Çalışanın soyadı: {0}", soyIsim);
        Console.WriteLine("Çalışanın numarası: {0}", no);
        Console.WriteLine("Çalışanın departmanı: {0}", departman);
    }
}