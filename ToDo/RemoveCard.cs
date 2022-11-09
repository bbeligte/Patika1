public class RemoveCard:CardWriter
{
    public void DeleteCard(List<Card> card)
    {
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:  ");

        string baslik = Console.ReadLine();
        int endOrRepeat;
        bool found = false;
        
        for (int i = 0; i < card.Count; i++)
        {
            if(card[i].Baslik == baslik)
            {
                found = true;
                Console.WriteLine($"{card[i].Baslik} başlıklı kartı silinmek üzere, onaylıyor musunuz ?(y/n)");
                if(Console.ReadLine() == "y")
                    card.Remove(card[i]);
                else if(Console.ReadLine() == "n")
                    return;
                break;
            }
        }
        
        if(found == false)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            endOrRepeat = int.Parse(Console.ReadLine());
            if(endOrRepeat == 1)
                return;
            else if(endOrRepeat == 2)
                DeleteCard(card);
                endOrRepeat = 0;
        }

        Console.WriteLine("TODO Line");
        Console.WriteLine("************************");
        Console.WriteLine("");
        base.Writer(card);
    }
}