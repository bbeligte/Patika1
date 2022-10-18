namespace arayuzler_ornek
{
    public class Focus : IOto
    {
        public Marka HangiMarka()
        {
            return Marka.Ford;
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