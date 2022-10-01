internal class Program
{
    private static void Main(string[] args)
    {   
        Methods methods = new Methods();

        //Tüm sayılar
        List<int> G = new List<int>();
        //Büyük sayılar
        List<int> B = new List<int>();
        //Küçük sayılar
        List<int> K = new List<int>();

        Console.WriteLine("****Soru 2****");

        Console.WriteLine("Lütfen 20 adet sayı giriniz:");

        for (int i = 0; i < 20; i++)
        {
            int x = int.Parse(Console.ReadLine());

            G.Add(x);
        }

        G.Sort();

        //Aşağıdakiler yerine Linq ile take() metodu kullanılabilir.

        for (int y = 0; y < 3; y++)
        {
            K.Add(G[y]);
        }

        for(int z = 17; z<20; z++)
        {
            B.Add(G[z]);
        }

        float kAv = methods.GetAv(K);
        float bAv = methods.GetAv(B);

        Console.WriteLine("Küçük sayılar listesi ortalaması: " +  kAv);
        Console.WriteLine("Büyük sayılar listesi ortalaması: " +  bAv);

        Console.WriteLine("Ortalamaların toplamı: " + kAv + bAv);
    }
}

class Methods
{
    public float GetAv(List<int> l)
    {
        float Average = 0;

        foreach (int x in l)
        {
            Average = Average += x;
        }
        Average = Average/2;
        return Average;
    }
}