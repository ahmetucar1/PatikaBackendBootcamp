using System;

namespace ManavUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");

            Console.WriteLine("\nHangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diger)");
            string meyve = Console.ReadLine().ToLower(); // Harf duyarlılığını kaldırdık

            // If/Else ile çözüm
            /*
            if (meyve == "elma")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            }
            else if (meyve == "armut")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            }
            else if (meyve == "çilek")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            }
            else if (meyve == "muz")
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            }
            else
            {
                Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
            }
*/
            // Switch-Case ile çözüm
            switch (meyve)
            {
                case "elma":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
                    break;
            }
        }
    }
}
