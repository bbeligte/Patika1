public class Search:Show
{
    public void SearchContact(List<Contact> list)
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine("");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

        int s = int.Parse(Console.ReadLine());
        
        if(s == 1)
        {
            Console.WriteLine("Aramak istediğiniz kişi adını ya da soyadını giriniz");
            string cSearch = Console.ReadLine();

            Console.WriteLine("Arama sonuçlarınız:");
            Console.WriteLine("**********************************************");

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Name == cSearch || list[i].Lastname == cSearch)
                {
                    Console.WriteLine($"İsim: {list[i].Name}");
                    Console.WriteLine($"Soyisim: {list[i].Lastname}");
                    Console.WriteLine($"Numara: {list[i].Number}");
                    Console.WriteLine("");
                }
            }
        }

        else
        {
            Console.WriteLine("Aramak istediğiniz kişinin numarasını giriniz");
            int nSearch = int.Parse(Console.ReadLine());

            Console.WriteLine("Arama sonuçlarınız:");
            Console.WriteLine("**********************************************");

            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].Number == nSearch)
                {                   
                    Console.WriteLine($"İsim: {list[i].Name}");
                    Console.WriteLine($"Soyisim: {list[i].Lastname}");
                    Console.WriteLine($"Numara: {list[i].Number}");
                    Console.WriteLine("");
                }
            }
        }
    }
}