internal class ToDo
{
    private static void Main(string[] args)
    {
        ToDoList toDoListClass = new();
        InProgress inProg = new();
        Done done = new();
        List<Card> cards = new List<Card>();
        Card ex = new Card("Örnek", "Kart", Sizes.L);
        Card ex2 = new Card("Örnek2", "Kart2", Sizes.XL);
        cards.Add(ex);
        cards.Add(ex2);

        Dictionary<int, string> teamList = new Dictionary<int, string>();
        Dictionary<int, string> toDoList = new Dictionary<int, string>();
        Dictionary<int, string> inProgList = new Dictionary<int, string>();
        Dictionary<int, string> dones = new Dictionary<int, string>();

        #region teamList
        teamList.Add(1, "Ethem");
        teamList.Add(2, "Elif");
        teamList.Add(3, "Aybike");
        teamList.Add(4, "Rojda");
        #endregion

        int op;

        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
        Console.WriteLine("*******************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");

        op = int.Parse(Console.ReadLine());

        if(op == 1)
        {
            toDoListClass.Lines(cards, toDoList);
            inProg.Lines(cards, inProgList);
            done.Lines(cards, dones);
        }
        else if(op == 2)
        {
            NewCard newCard = new();
            newCard.AddCard(cards, teamList);
        }
        else if(op == 3)
        {
            RemoveCard removeCard = new();
            removeCard.DeleteCard(cards);
        }
    }
}