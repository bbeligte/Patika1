public class List:Show
{
    public void ShowContacts(List<Contact> list, Contact x, Contact y)
    {
        Console.WriteLine("A'dan Z'ye sıralı görmek için 1'e, Z'den A'ya sıralı görmek için 2'ye basınız.");
        string az = Console.ReadLine();
        list.Sort((x, y) => x.Name.CompareTo(y.Name));

        if(az == "1")
        {           
            Console.WriteLine("");
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i+1 + ". Kişi");
                Console.WriteLine("İsim   : " + list[i].Name);
                Console.WriteLine("Soyisim: " + list[i].Lastname);
                Console.WriteLine("Numara : " + list[i].Number.ToString());
                Console.WriteLine("");
            }
        }

        else
        {
            list.Reverse();
            Console.WriteLine("");
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(i+1 + ". Kişi");
                Console.WriteLine("İsim   : " + list[i].Name);
                Console.WriteLine("Soyisim: " + list[i].Lastname);
                Console.WriteLine("Numara : " + list[i].Number.ToString());
                Console.WriteLine("");
            }
        }        
    }
}