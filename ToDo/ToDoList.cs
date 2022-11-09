public class ToDoList:IBoard
{
public void Lines(List<Card> card, Dictionary<int, string> toDoList)
    {
        //****Todo
        Card card1 = new("Kart 1", "İçerik", Sizes.S);
        Card card2 = new("Kart 2", "İçerik", Sizes.XS);
        card.Add(card1);
        card.Add(card2);

        toDoList.Add(1, "Ahmet");
        toDoList.Add(2, "Mehmet");

        Console.WriteLine("TODO Line");
        Console.WriteLine("************************");

        if(toDoList.Count > 0)
        {
            for (int i = 0; i < toDoList.Count; i++)
            {
                KeyValuePair<int, string>dict = toDoList.ElementAt(i);

                Console.WriteLine("Başlık      : " + card[i].Baslik);
                Console.WriteLine("İçerik      : " + card[i].Icerik);
                Console.WriteLine($"Atanan Kişi : {dict.Value}");
                Console.WriteLine("Büyüklük    : " + card[i].Size);
                Console.WriteLine("");
            }  
        }                    
        else
            Console.WriteLine("~ BOŞ ~");
    }
}