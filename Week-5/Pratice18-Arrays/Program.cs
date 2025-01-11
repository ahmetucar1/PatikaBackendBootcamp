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
        int[] numbers = new int[10];

        // 2 - Bu dizinin elemanlarını bir for döngüsü ile doldurup,
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 1;
        }

        //foreach döngüsü ile tekrar ekrana yazınız.
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // 3 - Bu diziye kullanıcıdan alınan yeni bir değeri ekleyiniz (11. eleman olarak)
        Console.WriteLine("Diziye eklemek istediğiniz yeni bir tam sayı girin:");
        int yeniDeger = Convert.ToInt32(Console.ReadLine());

        // yeni bir dizi oluşturup, eski diziyi kopyalıyoruz.
        int[] yeniDizi = new int[numbers.Length + 1];
        for (int i = 0; i < numbers.Length; i++)
        {
            yeniDizi[i] = numbers[i]; // Eski diziyi yeni diziye kopyalıyoruz
        }

        // yeni elemanı yeni dizinin sonuna ekliyoruz.
        yeniDizi[yeniDizi.Length - 1] = yeniDeger;

        Console.WriteLine("Yeni eleman eklendi. Güncellenmiş dizi:");
        foreach (int number in yeniDizi)
        {
            Console.WriteLine(number);
        }

        // 4. Diziyi büyükten küçüğe sırala
        Array.Sort(yeniDizi);
        Array.Reverse(yeniDizi);

        Console.WriteLine("Dizi büyükten küçüğe sıralandı:");
        foreach (int number in yeniDizi)
        {
            Console.WriteLine(number);
        }
    }
}
