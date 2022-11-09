public class CardWriter
{
    public void Writer(List<Card>list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("Başlık      : " + list[i].Baslik);
            Console.WriteLine("İçerik      : " + list[i].Icerik);
            Console.WriteLine("Büyüklük    : " + list[i].Size);
            Console.WriteLine("");
        }
    }
}