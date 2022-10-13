using System;

public class Bitkiler:Canlilar
{
    protected void Büyümek()
    {
        Console.WriteLine("Bitkiler büyür.");
    }
}

class Sebzeler:Bitkiler
{

    public Sebzeler()
    {
        base.Büyümek();
    }

    public void Cekirdeksiz()
    {
        Console.WriteLine("Sebzeler çekirdesizdir.");
    }
}

class Meyveler:Bitkiler
{
    public Meyveler()
    {
        base.Büyümek();
    }

    public void Cekirdekli()
    {
        Console.WriteLine("Meyveler çekirdeklidir.");
    }
}