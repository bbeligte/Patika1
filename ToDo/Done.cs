public class Done:IBoard
{
    public void Lines(List<Card> card, Dictionary<int, string> Dones)
    {
        #region Done
        //****Done
        Card card1 = new("Kart 1", "İçerik", Sizes.XL);
        card.Add(card1);

        Dones.Add(4, "Kayra");

        Console.WriteLine("DONE Line");
        Console.WriteLine("************************");

        if(Dones.Count > 0)
        {
            for (int i = 0; i < Dones.Count; i++)
            {
                KeyValuePair<int, string>dict = Dones.ElementAt(i);

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