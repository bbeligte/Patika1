namespace arayuzler_ornek
{
    public class Corolla:IOto
    {
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public int KacTekerlek()
        {
            return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }
}