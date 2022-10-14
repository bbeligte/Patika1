internal class Ademoglu:Adem
{
    public override void Boy(){
        Console.WriteLine("Ademoğlu'nun boyu, Adem'den 5 cm uzundur.");
    }

    public override void Sac()
    {
        Console.WriteLine("Ademoğlu'nun saçı sarıdır.");
    }

    public override void Yemek()
    {
        base.Yemek();
        Console.WriteLine("Ademoğlu, Adem'le aynı yemekleri sever.");
    }

    public override void Is()
    {
        Console.WriteLine("Ademoğlu insan olmaya çalışır.");
    }

}