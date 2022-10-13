using System;

public class Hayvanlar:Canlilar
{
    public Hayvanlar()
    {
        base.Solumak();
        base.Uremek();
    }

    protected void Adaptasyon()
    {
        Console.WriteLine("Hayvanlar adapte olur.");
    }
}

public class Kedi:Hayvanlar
{
    public Kedi()
    {
        base.Adaptasyon();
    }

    public void Miyav()
    {
        Console.WriteLine("Kediler miyavlar.");
    }
}
class Kopek:Hayvanlar
{

    public Kopek()
    {
        base.Adaptasyon();
    }

    public void Hav()
    {
        Console.WriteLine("Köpekler havlar.");
    }
}