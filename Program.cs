using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string s = "Patika";
        char c = 'c';

        uint ui = 10;
        int i = 12;
        Int32 i32 = 32;
        Int16 i16 = 16;
        Int64 i64 = 64;

        long l = 1;
        ulong ul = 2;

        object o1 = "Hello";

        bool write = true;

        string date = DateTime.Now.ToString("mm.dd.yyyy");
        Console.WriteLine(date);

        string hour = DateTime.Now.ToString("hh:mm");
        Console.WriteLine(hour);

        if(write == true)
        {
            Console.WriteLine(o1 + " " + s);
        }

        else
        {
            return;
        }
    }
}