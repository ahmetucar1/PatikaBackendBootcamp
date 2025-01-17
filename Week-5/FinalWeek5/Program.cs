using System;
using System.Collections.Generic;

namespace FinalWeeek5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>(); 

            while (true)
            {
                Console.WriteLine("Araba üretmek istiyor musunuz? (e/h)");
                string answer = Console.ReadLine()?.ToLower();

                if (answer == "h")
                {
                    Console.WriteLine("Program sonlandırılıyor...");
                    break;
                }
                else if (answer == "e")
                {
                    try
                    {
                        Console.WriteLine("Bir seri numarası girin:");
                        int serialNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Araba markası giriniz:");
                        string brand = Console.ReadLine();

                        Console.WriteLine("Araba modeli giriniz:");
                        string model = Console.ReadLine();

                        Console.WriteLine("Araba rengi giriniz:");
                        string color = Console.ReadLine();

                    doorInput:
                        Console.WriteLine("Kapı sayısını giriniz:");
                        if (!int.TryParse(Console.ReadLine(), out int doorCount))
                        {
                            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen sayısal bir değer giriniz.");
                            goto doorInput;
                        }

                        
                        Car car = new Car(serialNumber, brand, model, color, doorCount, DateTime.Now);
                        cars.Add(car);

                        Console.WriteLine("Araba başarıyla üretildi!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Geçersiz değer girdiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz bir cevap verdiniz. Lütfen 'e' veya 'h' giriniz.");
                }
            }

            Console.WriteLine("\nÜretilen Arabalar:");
            foreach (var car in cars)
            {
                car.DisplayCar();
            }
        }
    }
}