using System;
using Pratice16;

namespace Pratice16Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Square area calculation
            Square square = new Square();
            square.Width = 4;
            square.Height = 4;
            Console.WriteLine("Kare için alan hesaplam");
            square.AreaCalculation(); // Çıktı: Alan = 16

            // Rectangle area calculation
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine("Dikdörtgen için alan hesaplam");
            rectangle.AreaCalculation(); // Çıktı: Alan = 50

            // Right Triangle area calculation
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.Width = 6;
            rightTriangle.Height = 8;
            Console.WriteLine("Dik Üçgen için alan hesaplam");
            rightTriangle.AreaCalculation(); // Çıktı: Alan = 24
        }
    }
}
