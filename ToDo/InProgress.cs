public class InProgress:IBoard
{
    public void Lines(List<Card> card, Dictionary<int, string> inProgList)
    {
        #region inProg
        //****inProg
        Card card1 = new("Kart 1", "İçerik", Sizes.M);
        card.Add(card1);

        inProgList.Add(3, "Balamir");

        Console.WriteLine("IN PROGRESS Line");
        Console.WriteLine("************************");
        
        if(inProgList.Count > 0)
        {
            for (int i = 0; i < inProgList.Count; i++)
            {
                KeyValuePair<int, string>dict = inProgList.ElementAt(i);

                Console.WriteLine("Başlık      : " + card[i].Baslik);
                Console.WriteLine("İçerik      : " + card[i].Icerik);
                Console.WriteLine($"Atanan Kişi : {dict.Value}");
                Console.WriteLine("Büyüklük    : " + card[i].Size);
                Console.WriteLine("");
            }  
        }
        else
            Console.WriteLine("~ BOŞ ~");
        #endregion
    }
}