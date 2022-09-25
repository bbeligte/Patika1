internal class Program
{
    private static void Main(string[] args)
    {
        Poet poet = new Poet();

        #region strings
        string s1 = "yâr olur ağyâr olur dildâr olur serdâr olur";
        string s2 = "sanma şâhım herkesi sen sâdıkâne ";
        string s3 = " dost mu sandın belki ol";
        string s4 = " bu alemde ";
        #endregion

        poet.Writer(s1,s2,s3,s4);

    }
}

public class Poet
{
    public void Writer(string s1, string s2, string s3, string s4)
    {
        Console.WriteLine(s2 + s1.Substring(0,8));
        Console.WriteLine(s2.Split(' ')[2] + s3.Substring(0,1) + s2.Split(' ')[3] + s3 + s1.Substring(8,11));
        Console.WriteLine(s2.Remove(0,24) + s3.Remove(0,16) + s4 + s1.Substring(20,11));
        Console.WriteLine(s1);
    }
}