namespace arayuzler_ornek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***Interface***");
            Focus focus = new();
            Console.WriteLine(focus.HangiMarka().ToString());
            Console.WriteLine(focus.KacTekerlek());
            Console.WriteLine(focus.StandartRenk().ToString());

            Console.WriteLine("***Abstract***");
            NewCorolla nCorolla = new();
            Console.WriteLine(nCorolla.HangiMarka().ToString());
            Console.WriteLine(nCorolla.KacTekerlek());
            Console.WriteLine(nCorolla.StandartRenk().ToString());

        }
    }
}