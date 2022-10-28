public class Save:Show
{
    public void SaveContact(List<Contact> list)
    {
        Contact newContact = new();

        Console.WriteLine("Lütfen isim giriniz             :");
        newContact.Name = Console.ReadLine();   
        Console.WriteLine("Lütfen soyisim giriniz          :");
        newContact.Lastname = Console.ReadLine();
        Console.WriteLine("Lütfen telefon numarası giriniz :");
        newContact.Number = int.Parse(Console.ReadLine());

        list.Add(newContact);
    }
}