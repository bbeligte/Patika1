internal class Ademkizi:Adem
{
    public override void Boy(){
        Console.WriteLine("Ademkızı'nın boyu, Adem'den 3 cm uzundur.");
    }

    public override void Sac()
    {
        Console.WriteLine("Ademkızı'nın saçı sarıdır.");
    }

    public override void Yemek()
    {
        Console.WriteLine("Ademkızı, hamburger, patates kızartması ve sake sever.");
    }

    public override void Is()
    {
        base.Boy();
        Console.WriteLine("Ademkızı insan olmaya çalışır.");
    }
}