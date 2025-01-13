/*
Pratik - Array
Bu pratikte aşağıdaki 4 aşamayı kodlamanız isteniyor.

1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.

2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazınız.

3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)

4 - Bu diziyi büyükten küçüğe ekrana yazdırınız.
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        // 1 - 10 adet tam sayı verisi alacak bir dizi tanımlayınız.
        int[] numbers = new int[11]; //11 Olarak tanımlamamızın sebebi daha sonra eklenecek bir elemandan dolayı
        int currentLength = 10; // 10 adet tam sayıyı yazdırmak için gerekli bi değişken tanımlaması

        // 2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup,
        for (int i = 0; i < currentLength; i++)
        {
            numbers[i] = i + 1; // Diziyi 1'den 10'a kadar doldurmak için i + 1 yapıyoruz. 
        }

        //foreach döngüsü ile tekrar ekrana yazınız.
        foreach (int number in numbers)
        {
            if (number != 0) // Bu kontrolu eklemediğimizde 11. eleman 0 olur.
            {
                Console.WriteLine(number);
            }
        }

        //3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Console.WriteLine("Diziye eklemek istediğiniz yeni bir tam sayı girin:");
        int yeniDeger = Convert.ToInt32(Console.ReadLine());

         // Yeni elemanı mevcut uzunluğun sonuna ekleyip
        numbers[currentLength] = yeniDeger;
        currentLength++; // Geçerli uzunluğu artırrıyoruz.

          Console.WriteLine("Yeni eleman eklendi.");
        foreach (int number in numbers)
        {
            if (number != 0) // Boş elemanları atlamak için kontrol
            {
                Console.WriteLine(number);
            }
        }
           // 4. Diziyi büyükten küçüğe sırala
        Array.Sort(numbers, 0, currentLength); // sadece dolu kısmı sıralamak için
        Array.Reverse(numbers, 0, currentLength); // sadece dolu kısmı ters çevirmek için

         // Sıralanmış diziyi ekrana yazdırma
        Console.WriteLine("Dizi büyükten küçüğe sıralandı");
        foreach (int number in numbers)
        {
            if (number != 0) // Boş elemanları atlamak için kontrol
            {
                Console.WriteLine(number);
            }
        }

    }
}
