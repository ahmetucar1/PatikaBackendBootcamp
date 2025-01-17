/*
 Aşağıda belirtilen adımları gerçekleştirerek bir Imdb - Film Listesi oluşturuyoruz.

Sinema Filmlerini listeleyeceğimiz bir liste oluşturalım.

Film için propertyler -> Imdb Puanı (Double) - İsmi 

Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.

 Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun. Kullanıcı evet cevabını verirse döngüde başa dönülerek yeni bir film oluşturulup ilgili listeye aktarılsın. Hayır cevabı verilirse program aşağıdaki çıktıları ayrı ayrı sunarak sonlandırılsın.

    Uygulamanın sonunda

 Bütün filmler listelensin.

 Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.

 İsmi 'A' ile başlayan filmler ve imdb puanları listelensin
*/

using System;

namespace IMBDList
{
   class Program
{
    static void Main()
    {
        List<Film> filmListesi = new List<Film>();
        string devamEt;
        
        do
        {
            // Kullanıcıdan film adı ve imdb puanı alınır
            Console.WriteLine("Film adı girin: ");
            string filmAdi = Console.ReadLine();
            
            Console.WriteLine("IMDb puanı girin: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))  // Geçerli bir double girilene kadar bekler
            {
                Console.Write("Lütfen geçerli bir IMDb puanı girin: ");
            }

            // Film nesnesi oluşturulup listeye eklenir
            Film yeniFilm = new Film(filmAdi, imdbPuani);
            filmListesi.Add(yeniFilm);

            // Yeni film eklemek isteyip istemediğini sorar
            Console.WriteLine("Başka bir film eklemek ister misiniz? (Evet/Hayır): ");
            devamEt = Console.ReadLine().ToLower();

        } while (devamEt == "evet");

        // 1. Tüm filmleri listeleme
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine($"Film Adı: {film.Ad}, IMDb Puanı: {film.ImdbPuani}");
        }

        // 2. IMDb puanı 4 ile 9 arasında olan filmleri listeleme
        Console.WriteLine("\nIMDb Puanı 4 ile 9 arasında olan Filmler:");
        foreach (var film in filmListesi)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film Adı: {film.Ad}, IMDb Puanı: {film.ImdbPuani}");
            }
        }

        // 3. İsmi 'A' ile başlayan filmleri listeleme
        Console.WriteLine("\nİsmi 'A' ile başlayan Filmler:");
        foreach (var film in filmListesi)
        {
            // 'A' harfi ile başlayan filmleri kontrol et
            if (film.Ad.Length > 0 && film.Ad[0] == 'A' || film.Ad[0] == 'a')
            {
                Console.WriteLine($"Film Adı: {film.Ad}, IMDb Puanı: {film.ImdbPuani}");
            }
        }
    }
}
}