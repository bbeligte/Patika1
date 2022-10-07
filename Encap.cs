internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci("Harrier", "du Bois", 44, 2);
        ogrenci.OgrenciYazdir();
        ogrenci.SinifAtlat();
        ogrenci.OgrenciYazdir();

        Ogrenci ogrenci2 = new Ogrenci("Kim", "Kitsuragi", 43, 1);
        ogrenci2.OgrenciYazdir();
        ogrenci2.SinifDusur();
        ogrenci2.OgrenciYazdir();
    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int no;
        private int sinif;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad {get => soyad; set => soyad = value;}
        public int No { get => no; set => no = value; }
        public int Sinif 
        { 
            get => sinif; 
            
            set 
            { 
                if(value < 1)
                {
                    Console.WriteLine("Sınıf, 1'den küçük olamaz.");
                    sinif = 1;
                }
                else
                    sinif = value;               
            }
        }

        public Ogrenci(string Ad, string Soyad, int No, int Sinif)
        {
            ad = Ad;
            soyad = Soyad;
            no = No;
            sinif = Sinif;
        }

        public void OgrenciYazdir()
        {
            Console.WriteLine("***Öğrenci Bilgileri***");
            Console.WriteLine("Öğrenci Adı:    {0}",Ad);
            Console.WriteLine("Öğrenci Soyadı: {0}",Soyad);
            Console.WriteLine("Öğrenci No:     {0}",No);
            Console.WriteLine("Öğrenci Sınıf:  {0}",Sinif);
            Console.WriteLine("");
        }

        public void SinifAtlat()
        {
            Console.WriteLine($"{Ad} {Soyad} isimli öğrenci sınıf atlatıldı!");
            Sinif+=1;
        }

        public void SinifDusur()
        {
            Console.WriteLine($"{Ad} {Soyad} isimli öğrenci sınıf düşürüldü!");
            Sinif-=1;
        }
    }
}