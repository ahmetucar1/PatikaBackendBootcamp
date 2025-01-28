/*
Bu pratikte sizlerden bir Diziler listesi oluşturmanız ve içerisindeki nesneleri tanımlamanız bekleniyor. Elemanların oluşturuluşu Console ekranı üzerinden olacak.
Yani kullanıcıya her diziyi oluşturup listeye ekledikten sonra yeni bir dizi ekleyip eklemediğini sormamız gerekiyor.
Ardından aşağıda istenilen işlemleri gerçekleştiriniz.
İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)
Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.
*/

using System;

namespace Patikaflix
{
    class Program
    {
        static void Main(string[] args)
        {

        //Bu burada kalsın lazım olacak
        List<Series> series = new List<Series>();

       while (true)
            {
                string name;
                while (true)
                {
                    Console.WriteLine("Dizi adı giriniz: ");
                    name = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(name) && name.All(c => char.IsLetter(c) || c == ' ')) //Kullanıcının insan gibi veri girmesini sağlıyoruz
                    break;
                    Console.WriteLine("Geçersiz değer girdiniz. Girmeyin!"); //Aksi takdirde kızıyoruz.Eğitilmez gerçekten bunlar.
                }

                int productionYear;
                while (true)
                {
                    Console.WriteLine("Yapım yılını giriniz: ");
                    if (int.TryParse(Console.ReadLine(), out productionYear)) //Yapım yılını alıp int'e çeviriyoruz.
                        break;
                    Console.WriteLine("Geçersiz değer girdiniz. Yapmayınız.");
                }

                string genre;
                while (true)
                {
                    Console.WriteLine("Dizi türü giriniz: ");
                    genre = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(genre) && genre.All(c => char.IsLetter(c) || c == ' ')) //Kullanıcının insan gibi veri girmesini sağlıyoruz
                    break;
                    Console.WriteLine("Geçersiz değer girdiniz. Lan oğlum böyle olmaz! ♫"); //Aksi takdirde kızıyoruz.Eğitilmez gerçekten bunlar.
                }
             
                int startYear;
                while (true)
                {
                    Console.WriteLine("Yayına başlama yılını giriniz: ");
                    if (int.TryParse(Console.ReadLine(), out startYear)) //Yayın yılını alıp int'e çeviriyoruz.
                        break;
                    Console.WriteLine("Geçersiz değer girdiniz. Yapmayınız.");
                }
                
                string director;
                while (true)
                {
                    Console.WriteLine("Dizi yönetmenini giriniz: ");
                    director = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(director) && director.All(c => char.IsLetter(c) || c == ' ')) //Kullanıcının insan gibi veri girmesini sağlıyoruz
                    break;
                    Console.WriteLine("Geçersiz değer girdiniz. Lan oğlum böyle olmaz! ♫"); //Aksi takdirde kızıyoruz.Eğitilmez gerçekten bunlar.
                }

                string platform;
                while (true)
                {
                    Console.WriteLine("Dizi platformunu giriniz: ");
                    platform = Console.ReadLine().Trim();
                    if (!string.IsNullOrEmpty(platform) && platform.All(c => char.IsLetter(c) || c == ' ')) //Kullanıcının insan gibi veri girmesini sağlıyoruz
                    break;
                    Console.WriteLine("Geçersiz değer girdiniz. Lan oğlum böyle olmaz! ♫"); //Aksi takdirde kızıyoruz.Eğitilmez gerçekten bunlar.
                }
                
                //Kullanıcıdan aldığımız verilerle yeni bir nesne oluşturup listeye ekliyoruz.
                Series newSeries = new Series(name, productionYear, genre, startYear, director, platform);
                series.Add(newSeries);
                Console.WriteLine($"'{name}' dizisi listeye eklendi.\n");

                // Kullanıcıya yeni dizi ekleyip eklemeyeceğini soruyoruz
                Console.Write("Başka dizi girecen mi? (he girecem/yoğ): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "he girecem")
                break;
        }

        // Dizileri yazdırıyoruz.
            Console.WriteLine("\nEklenen Diziler:");
            foreach (var seri in series)
            {
                Console.WriteLine($"Ad: {seri.Name}, Yapım Yılı: {seri.ProductionYear}, Tür: {seri.Genre},Yayına Başlama Yılı: {seri.StartYear}, Yönetmen: {seri.Director}, Platform: {seri.Platform}");
            }

              // Komedi dizilerinden yeni bir liste oluşturuyoruz
            List<ComedySeries> comedySeriesList = series
                .Where(s => s.Genre.ToLower() == "komedi")
                .Select(s => new ComedySeries(s.Name, s.Genre, s.Director))
                .ToList();

            // Dizileri sıralıyoruz
            var sortedComedySeries = comedySeriesList
                .OrderBy(c => c.Name) // Dizi adına göre sıralama
                .ThenBy(c => c.Director) // Yönetmene göre sıralama
                .ToList();

            // Sıralanmış komedi dizilerini ekrana yazdırıyoruz
            Console.WriteLine("\nKomedi Dizileri (Sıralı):");
            foreach (var comedy in sortedComedySeries)
            {
                Console.WriteLine($"Dizi Adı: {comedy.Name}, Tür: {comedy.Genre}, Yönetmen: {comedy.Director}");
            }

        }
    }
}