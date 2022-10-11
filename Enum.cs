internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hava sıcaklığını giriniz: ");

        int sicaklik = int.Parse(Console.ReadLine());

        if (sicaklik <= (int)Havadurumu.soguk)
            Console.WriteLine("Hava soğuk");
        else if (sicaklik >= (int)Havadurumu.iyi && sicaklik < (int)Havadurumu.sicak )
            Console.WriteLine("Hava güzel");
        else
            Console.WriteLine("Hava sıcak");
    }

    enum Havadurumu
    {
        soguk = 14,
        iyi = 15,
        sicak = 30
    }
}