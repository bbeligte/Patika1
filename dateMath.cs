internal class Program
{
    private static void Main(string[] args)
    {
        double yearOfDeath = 0;
        double timeLeft = 0;

        Console.WriteLine("Lütfen doğduğunuz yılı giriniz: ");
        int by = int.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen biyolojik cinsiyetiniz erkek ise 1, kadın ise 2'yi tuşlayınız: ");
        int sex = int.Parse(Console.ReadLine());

        int year = DateTime.Now.Year;

        if(sex == 1)
        {
            yearOfDeath = Math.Round(75.6) - (year-by) + year;
            timeLeft =  (yearOfDeath - year) * 8766;
        }
        else
        {
            yearOfDeath = Math.Ceiling(81.2) - (year-by) + year;
            timeLeft =  (yearOfDeath - year) * 8766;
        }
            
        Console.WriteLine("Öleceğinizi tahmin ettiğimiz yıl: ");
        Console.WriteLine(yearOfDeath);
        Console.WriteLine("Kalan, yaklaşık, saatleriniz: ");
        Console.Write(timeLeft.ToString().Insert(3, "."));
    }
}