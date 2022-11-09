public class Card
{
    string baslik;
    string icerik;
    Sizes size;

    public string Baslik{get => baslik; set => baslik = value;}
    public string Icerik{get => icerik; set => icerik = value;}
    public Sizes Size{get => size; set => size = value;}

    public Card(string Baslik, string Icerik, Sizes Size)
    {
        this.baslik = Baslik;
        this.icerik = Icerik;
        this.size = Size;
    }
}