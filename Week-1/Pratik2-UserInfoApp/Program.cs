using System;

namespace ExampleTwo
{
    class Program
    {
        static void Main(String[] args)
        {
            string start = "Lütfen aşağıdaki bilgileri giriniz:";
            Console.WriteLine(start);

            Console.WriteLine("Tc Kimlik Numarası:");
            string idNumber = Console.ReadLine();

            Console.WriteLine("Adınız:");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadınız:");
            string surname = Console.ReadLine();

            //Bu değer string bir ifade olmayacağı için string? kullandım.
            Console.WriteLine("Telefon Numarası:");
            string? phoneNumber = Console.ReadLine();

            //Bu değer string bir ifade olmayacağı için string? kullandım.
            Console.WriteLine("Yaşınız:");
            string? age = Console.ReadLine();

            // Ürün fiyatlarını toplam kazanılan puanı bulabilmek için chasing yaparak double kullandım.
            Console.WriteLine("İlk ürünün fiyatını girin: ");
            double price1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci ürünün fiyatını girin: ");
            double price2 = Convert.ToDouble(Console.ReadLine());

            // Fiyatları topla
            double totalPrice = price1 + price2;

            // İndirim oranı 
            double discount = 0.10; // %10 indirim

            // İndirimli fiyat hesapla
            double discountAmount = totalPrice * discount;
            double discountPrice = totalPrice - discountAmount;

            // Çıktıyı formatla
            Console.WriteLine($"{idNumber} Tc Numaralı {name} {surname} isimli kullanıcı için kayıt oluşturulmuştur {phoneNumber} telefon numarasına bildirim mesajı gönderilmiştir. {totalPrice} toplam harcama karşılığı kazanılan %{discount * 100} patika puan miktarı -> {discountAmount} TL'dir. ");
        }
    }
}

