internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Zaman konumu sorgu terminaline hoşgeldiniz!");

        int month = DateTime.Now.Month;

        switch (month)
        {
            case 4:
                Console.WriteLine("Nisan ayındasınız.");
                break;
            case 6:
                Console.WriteLine("Haziran ayındasınız.");
                break;
            case 8:
                Console.WriteLine("Ağustos ayındasınız.");
                break;

            default:
                Console.WriteLine("Böyle bir ay yok. Lütfen olağanın dışına çıkmayın. En kısa sürede bir yetkili size ulaşacaktır, olduğunuz yeri terk etmeyin. *Bilinmeyen bir zamanda bulunduğunuz için tahmini varış süresi veremiyoruz.");               
                break;
        }

        switch (month)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış mevsimindesiniz.");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar mevsimindesiniz.");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz mevsimindesiniz.");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar mevsimindesiniz.");
                break;

            default:
                Console.WriteLine("Bilinmeyen bir mevsimdesiniz. Lütfen en yakınınızdaki yetkiliye müraacat ederek normale dönüşünüzü sağlayın.");
                break;
        }
    }
}