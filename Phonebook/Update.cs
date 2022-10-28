public class Update:Show
{
    public void UpdateContact(List<Contact> list)
    {
        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string search = Console.ReadLine();
        int endOrRepeat;
        bool found = false;
        
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i].Name == search || list[i].Lastname == search)
            {
                found = true;
                Console.WriteLine($"Lütfen {list[i].Name} kişisinin yeni numarasını giriniz:");
                list[i].Number = int.Parse(Console.ReadLine());
            }
        }
        
        if(found == false)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için           : (2)");
            endOrRepeat = int.Parse(Console.ReadLine());
            if(endOrRepeat == 1)
                return;
            else if(endOrRepeat == 2)
                UpdateContact(list);
                endOrRepeat = 0;
        }
    }
}