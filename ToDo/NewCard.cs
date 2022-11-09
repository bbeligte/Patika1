public class NewCard
{
    public void AddCard(List<Card> cardList, Dictionary<int,string> dic)
    {
        string kartBaslik;
        string kartIcerik;
        //Üstteki switch statement'ı için. İkinci atama için.
        byte ksize = 0;
        Sizes kartSize=Sizes.XS;
        int kartKisi;

        Console.WriteLine("Başlık Giriniz                                  :");
        kartBaslik = Console.ReadLine();
        Console.WriteLine("İçerik Giriniz                                  :");
        kartIcerik = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        ksize = byte.Parse(Console.ReadLine());
        switch (ksize)
        {
            case 1:
            kartSize = Sizes.XS;
                break;
            case 2:
            kartSize = Sizes.S;
                break;
            case 3:
            kartSize = Sizes.M;
                break;
            case 4:
            kartSize = Sizes.L;
                break;
            case 5:
            kartSize = Sizes.XL;
                break;
        }
        Console.WriteLine("Kişi Seçiniz                                    :");
        kartKisi = int.Parse(Console.ReadLine());

        Card card = new Card(kartBaslik, kartIcerik, kartSize);
        cardList.Add(card);
        
        #region writingGoesOnHere
        Console.WriteLine("");
        Console.WriteLine("Başlık      : " + kartBaslik);
        Console.WriteLine("İçerik      : " + kartIcerik);
        Console.WriteLine($"Atanan Kişi : {dic[kartKisi]}");
        Console.WriteLine("Büyüklük    : " + kartSize);
        Console.WriteLine("");
        #endregion
    }
}