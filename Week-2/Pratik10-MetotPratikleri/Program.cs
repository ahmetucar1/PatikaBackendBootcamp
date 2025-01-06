using System;

class Program
{
    static void Main()
    {
        // Değer döndürmeyen metot
        // Ekrana şarkı sözü yazdırma
    static void Yazdır()
    {
        Console.WriteLine("Süpermen, Süpermen olmak lazım bazen");
    }
    Yazdır();

    Console.WriteLine("--------------------");

    //Değer döndüren metot 
    //Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürme
     int RastgeleSayiOlustur()
     {
        Random rnd = new Random();
        return rnd.Next(1,1001) % 2;

     }
    Console.WriteLine(RastgeleSayiOlustur());
     
    Console.WriteLine("--------------------");

    //Parametre Alan ve Geriye Değer Döndüren Metot
    //Parametre olarak aldığı iki sayının çarpımını geriye döndürme.

    static int sayilariCarp(int a, int b)
    {
        return a * b;
    }

    {
      int result = sayilariCarp(5, 3);
      Console.WriteLine("Çarpım: " + result);
    }

    Console.WriteLine("---------------------");

    //Parametre Alan ve Geriye Değer Döndürmeyen Metot
    //Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana basma.

    void isimYazdir(string isim, string soyisim)
    {
     Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");
    }
    isimYazdir("Sertan", "Bozkuş");

    }

}
