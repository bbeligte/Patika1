public class Show
{
    public void JustShow(List<Contact> list)
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
}