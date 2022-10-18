namespace arayuzler_ornek
{
    public abstract class Otomobil
    {
        public int KacTekerlek()
        {
            return 4;
        }

        public virtual Renk StandartRenk()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarka();
    }
}