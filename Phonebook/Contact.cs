public class Contact:Show
{
    private string name, lastname;
    private int number;

    public string Name { get => name; set => name = value; }
    public string Lastname { get => lastname; set => lastname = value; }
    public int Number { get => number; set => number = value; }

    public Contact(string name, string lastname, int number)
    {
        Name = name;
        Lastname = lastname;
        Number = number;
    }

    public Contact(){}
}


