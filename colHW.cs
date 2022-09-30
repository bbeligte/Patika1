internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("**** Soru 1 ****");
        Console.WriteLine("Lütfen 20 sayı giriniz: ");
        int x,ctr;
        List<int> asal = new List<int>();
        List<int> asalDegil = new List<int>();

        try
        {

            for(int i = 0; i < 20; i++)
            {
                x = int.Parse(Console.ReadLine()); 
                ctr = 0;

                if(x<=0)
                {
                    Console.WriteLine("Pozitif bir sayı giriniz.");
                }

                for (int z = 2; z < x; z++)
                {                    
                    if(x%z == 0)
                    {
                        ctr++;
                        break;                                                
                    }                        
                }

                if(ctr == 0 && x != 1)
                    asal.Add(x);                
                else
                    asalDegil.Add(x);
            }

            

            asal.Sort();
            asalDegil.Sort();

            asal.ForEach(asals=> Console.WriteLine("Asal elemanlar: " + asals));
            asalDegil.ForEach(asalD=> Console.WriteLine("Asal olmayan elemanlar: " + asalD));

            Console.WriteLine("Asal olmayan liste eleman sayısı: " + asalDegil.Count);
            Console.WriteLine("Asal olmayan liste ortalaması: " + asalDegil.Average());
            Console.WriteLine("Asal liste eleman sayısı: " + asal.Count);            
            Console.WriteLine("Asal liste ortalaması: " + asal.Average());

        }
        
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Sayısal giriş yapınız: " + ex.ToString());
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Sayı giriniz: " + ex.ToString());
        }
        

    }
}