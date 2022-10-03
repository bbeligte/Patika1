internal class Program
{
    private static void Main(string[] args)
    {
        //Koleksiyonlar soru 3

        var sesliler = new HashSet<char> {'a','e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
        List<char> sHarfler = new List<char>();

        Console.WriteLine("Bir cümle giriniz: ");

        string s = Console.ReadLine().ToLower();

        for (int i = 0; i < s.Length; i++)
        {
            if(sesliler.Contains(s[i]))
            {
                sHarfler.Add(s[i]);
            }    
        }

        sHarfler.Sort();
        
        foreach (var c in sHarfler)
        {
            Console.Write(c);
        }
    }
}