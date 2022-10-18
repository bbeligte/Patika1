namespace arayuzler_ornek
{
    public class Civic:IOto
    {
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }

        public int KacTekerlek()
        {
            return 4;
        }
        
        public Renk StandartRenk()
        {
            return Renk.Beyaz;
        }
    }
}