using System.ComponentModel;

namespace Pratice12Class
{
    public class Kitap
    {
        // Kitap nesnesinin özellikleri (Properties)
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; private set; } // Kayıt tarihi dışarıdan değiştirilemez

        // Default constructor (parametresiz metot)
        public Kitap()
        {
            KayitTarihi = DateTime.Now; // Kayıt tarihi nesne oluşturulduğu an atanır
        }

        // Parametre alan constructor
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now; // Kayıt tarihi nesne oluşturulduğu an atanır
        }

        // Kitap bilgilerini yazdıran bir metot
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Kitap Adı: {Ad}");
            Console.WriteLine($"Yazar: {YazarAdi} {YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {Yayinevi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
        }
    }
}

