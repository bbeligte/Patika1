public class Phonebook
{
    public static void Main(string[] args)
    {
        int opNumber = 0;

        List<Contact> contacts = new List<Contact>();
        
        #region DefContacts
        Contact contact1 = new("Ahmet", "Mehmet" , 1111);
        Contact contact2 = new("Sevim", "Çığşar" , 2222);
        Contact contact3 = new("Barış", "Çınar" , 3333);
        Contact contact4 = new("Osman", "Göksel" , 4444);
        Contact contact5 = new("Eylül", "Çoban" , 5555);
        Contact contact6 = new("Ahmet", "Balcı" , 6666);

        contacts.Add(contact1);
        contacts.Add(contact2);
        contacts.Add(contact3);
        contacts.Add(contact4);
        contacts.Add(contact5);
        contacts.Add(contact6);
        #endregion

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");

        opNumber = int.Parse(Console.ReadLine());

        switch (opNumber)
        {
            case 1:
                Save save = new();
                save.SaveContact(contacts);
                save.JustShow(contacts);
                break;
            case 2:
                Delete delete = new();
                delete.DeleteContact(contacts);
                delete.JustShow(contacts);
                break;
            case 3:
                Update update = new();
                update.UpdateContact(contacts);
                update.JustShow(contacts);
                break;
            case 4:
                List list = new();
                list.ShowContacts(contacts, contacts[0], contacts[contacts.Count -1]);
                break;
            case 5:
                Search search = new();
                search.SearchContact(contacts);
                break;
        }
    }
}