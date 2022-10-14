public class Insanlik
{
    private static void Main(string[] args)
    {
        Hayat hayat = new Hayat();
        hayat.Kimlik();

        Console.WriteLine("*****");
        Console.WriteLine("");

        Ademkizi ademkizi = new Ademkizi();
        ademkizi.Is();
        ademkizi.Sac();
        ademkizi.Yemek();
        ademkizi.Boy();

        Console.WriteLine("*****");
        Console.WriteLine("");

        Ademoglu ademoglu = new Ademoglu();
        ademoglu.Is();
        ademoglu.Sac();
        ademoglu.Yemek();
        ademoglu.Boy();
    }
}