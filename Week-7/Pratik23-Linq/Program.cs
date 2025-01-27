/*
Rastgele 10 adet sayıdan oluşan bir liste oluşturunuz. Bu liste üzerinden aşağıdaki linq sorgularını çalıştırarak konsol ekranına istenilenleri yazdırınız.

Çift olan sayılar

Tek olan sayılar

Negatif sayılar

Pozitif Sayılar

15'ten büyük ve 22'den küçük sayılar

Listedeki her bir sayının karesi (Bunun için yeni bir liste oluşturup yazdırabilirsiniz.)
*/

using System;

namespace Linq
{

  class Program
  {
    static void Main(string[] args) {
  

       List<int> numbers = new List<int> { 5, 10, 22, 44, 34, -43, 8, 16, -9, 12};
       
       Console.WriteLine("Listedeki Çift Sayılar");
       var evenNumbers = numbers.Where(x => x % 2 == 0);
       
       foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Listedeki Tek Sayılar");

         var oddNumbers = numbers.Where(x => x % 2 == 1);
       
       foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Listedeki Negatif Sayılar");

        var negativeNumbers = numbers.Where(x => x < 0);
       
       foreach (var number in negativeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Listedeki Pozitif Sayılar");

        var pozitiveNumbers = numbers.Where(x => x < 1);
       
       foreach (var number in pozitiveNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Listedeki 15-22 Sayılar");

        var rangeNumbers = numbers.Where(x => x > 15 && x < 22);
       
       foreach (var number in rangeNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Listedeki üslü Sayılar");

        var usluNumbers = numbers.Select(x => x * x);
       
       foreach (var number in usluNumbers)
        {
            Console.WriteLine(number);
        }


        
    }
  }

}










