using System;
using System.Runtime.Intrinsics.X86;

namespace Patikafy
{
   class Program
   {
    static void Main(string[] args) 
    {
    //11 sanatçımız için bir veri tablosu verilmiştir. Tablodaki her bir satır bir nesneye karşılık gelecek şekilde bu nesnelerden oluşan bir liste tanımlayınız.
     List<Artists> artists = new List<Artists> 
     {
            new Artists("Ajda Pekkan", "Pop", 1968, 20000000),
            new Artists("Sezen Aksu", "Türk Halk Müziği/Pop", 1971, 10000000),
            new Artists("Funda Arar", "Pop", 1999, 300000),
            new Artists("Sertab Erener", "Pop", 1994, 1000000),
            new Artists("Sıla", "Pop", 2009, 3000000),
            new Artists("Serdar Ortaç", "Pop", 1994, 10000000),
            new Artists("Tarkan", "Pop", 1992, 40000000),
            new Artists("Hande Yener", "Pop", 1999, 7000000),
            new Artists("Hadise", "Pop", 2005, 5000000),
            new Artists("Gülben Ergen", "Türk Halk Müzigi/Pop", 1997, 10000000),
            new Artists("Neşet Ertaş", "Türk Halk Müzigi/Türk Sanat Müziği", 1960, 2000000),
     };
    
    //Adı 'S' ile başlayan şarkıcılar
    Console.WriteLine("Adı S ile başlayan sanatçılar");
    var startingS = artists.Where(artist => artist.Name.StartsWith("S"));

    foreach (var artist in startingS)
    {
        Console.WriteLine(artist.Name);
    }
    Console.WriteLine("--------------------");

    //Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
    Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
    var sales = artists.Where(artist => artist.AlbumSales > 10000000);

    foreach (var artist in sales)
    {
        Console.WriteLine($"{artist.Name} - {artist.AlbumSales}");
    }

    Console.WriteLine("--------------------");

    //2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar. ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.
    Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.( Çıkış yılı - Alfabetik Sıra)");
    var popArtist = artists.Where(artist => artist.Year < 2000 && artist.MusicGenre.Contains("Pop"))
                           .OrderBy(artist => artist.Name)
                           .GroupBy(artist => artist.Year);
        foreach (var group in popArtist)
        {
            foreach (var artist in group)
            {
                Console.WriteLine($"{artist.Year} - {artist.Name}");
            }
        }

    Console.WriteLine("--------------------");

    //En çok albüm satan şarkıcı
    Console.WriteLine("En çok albüm satan şarkıcı:");
    var bestSales = artists.OrderByDescending(artist => artist.AlbumSales).First();
    Console.WriteLine($"{bestSales.Name} Yaklaşık {bestSales.AlbumSales}");
    
    Console.WriteLine("--------------------");
    
    //En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı
    Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı");
    var newArtist = artists.OrderBy(artist => artist.Year).Last();
    Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newArtist.Name} - {newArtist.Year}");

    var oldArtist = artists.OrderBy(artist => artist.Year).First();
    Console.WriteLine($"En eski çıkış yapan şarkıcı : {oldArtist.Name} - {newArtist.Year}");
    
    }
   }
}
