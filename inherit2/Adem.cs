public class Adem:Insanlik
{
    public virtual void Boy(){
        Console.WriteLine("Adem'in boyu 1.80'dir.");
    }

    public virtual void Sac(){
        Console.WriteLine("Adem sarışındır.");
    }

    public virtual void Yemek(){
        Console.WriteLine("Adem, barbunya, kuru fasülye, pilav sever.");
    }

    public virtual void Is(){
        Console.WriteLine("Ademoğlu insan olmaya çalışır.");
    }
}

public class Hayat:Adem
{
    public Hayat(){
        base.Boy();
        base.Sac();
        base.Yemek();
        base.Is();
    }

    public void Kimlik(){
        Console.WriteLine("Adem yaşar ve ölür.");
    }
}