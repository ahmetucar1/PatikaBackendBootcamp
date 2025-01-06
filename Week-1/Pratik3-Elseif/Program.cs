using System;

namespace Example3

{
    class Program 
    {
        static void Main(String[] args)
        {
          // Kullanıcıdan bir sayı alınıp string veri tipi ile alınan sayı int çevriliyor.
          Console.WriteLine("Lütfen bir sayı giriniz : "); 
          string? stringSayi = Console.ReadLine(); 
          int.TryParse(stringSayi, out int sayi); 

          // Sayının ondan küçük olup olmadığı işlemleri koşullarla kontrol edilip sonuç yazdırılıyor.
          if (sayi < 10) 
          {
               Console.WriteLine("Girilen sayı 10'dan küçüktür.");
          }
          else if (sayi > 10)
          {
               Console.WriteLine("Girilen sayı 10'dan büyüktür");
          }
          else 
          {
               Console.WriteLine("Sayı 0'a eşittir.");
          }
          if (sayi % 2 == 0)
        {

           // Sayının tek mi çift mi olduğu kontrol ediliyor. Sonuç yazdırılıyor.
          Console.WriteLine("Girilen sayı çifttir."); 
        }
        else
        {
        Console.WriteLine("Girilen sayı tektir."); 
        }
        }
    }
}