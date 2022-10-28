public class Delete:Show
{
    public void DeleteContact(List<Contact> list)
    {
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string search = Console.ReadLine();
        int endOrRepeat;
        bool found = false;
        
        for (int i = 0; i < list.Count; i++)
        {
            if(list[i].Name == search || list[i].Lastname == search)
            {
                found = true;
                Console.WriteLine($"{list[i].Name} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                if(Console.ReadLine() == "y")
                    list.Remove(list[i]);
                else if(Console.ReadLine() == "n")
                    return;
                break;
            }
        }
        
        if(found == false)
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            endOrRepeat = int.Parse(Console.ReadLine());
            if(endOrRepeat == 1)
                return;
            else if(endOrRepeat == 2)
                DeleteContact(list);
                endOrRepeat = 0;
        }
    }
}