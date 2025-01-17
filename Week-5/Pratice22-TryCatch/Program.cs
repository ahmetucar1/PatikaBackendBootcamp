using System;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isValidInput = false;

            while (!isValidInput)
            {
               try
               {
                Console.WriteLine("Lütfen bir sayı girin!");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Girdiğiniz sayının değeri:" + number * number);
                
                isValidInput = true;
               }
               catch (FormatException ex)
               {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
               }
               break;
            }

        }
    }
}