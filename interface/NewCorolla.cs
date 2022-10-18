namespace arayuzler_ornek
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarka()
        {
            return Marka.Toyota;
        }

        public override Renk StandartRenk()
        {
            return Renk.Gri;
        }
    }
}