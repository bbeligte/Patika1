using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //string
        List<string> isimler = new List<string>();
        isimler.Add("Alp");
        isimler.Add("Kutalmış");

        isimler.ForEach(isim=> Console.WriteLine(isim));

        Console.WriteLine("*******");

        //int
        List<int> sayilar = new List<int>();
        sayilar.Add(1);
        sayilar.Add(2);

        sayilar.ForEach(sayi=> Console.WriteLine(sayi));

        Console.WriteLine("*******");

        //Diziyi list yap
        string[] hayvanlar = {"Aslan", "Kaplan"};
        List<string> hayvanlarList = new List<string>(hayvanlar);

        hayvanlarList.ForEach(hayvan=> Console.WriteLine(hayvan));

        //List içinde nesne
        Console.WriteLine("*******");

        List<Students> students = new List<Students>();

        Students students1 = new Students();
        students1.Name="Ayşe";
        students1.Number=1;

        students.Add(students1);

        students.ForEach(st=> Console.WriteLine(st.Name + " " + st.Number));


        //ArrayList
        Console.WriteLine("*******");

        ArrayList aList = new ArrayList();

        string[] renkler = {"kırmızı", "yeşil"};
        aList.AddRange(renkler);

        foreach (var renk in aList)
        {
            Console.WriteLine(renk);
        }

    }
}

public class Students
{
    string name;
    int number;

    public string Name{get=> name; set=> name = value;}

    public int Number{get=> number; set=> number = value;}
}