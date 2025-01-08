using System;
using Encapsulation;

namespace Pratik13
{
    class Encapsulation
    {
        static void Main(string[] args)
        {

        Car car = new Car("Audi", "A4", "Siyah", 4); //new object
        
        car.DisplayCar(); 

        car.NumberDoors = 3; //Code written to test for unacceptable value

        car.DisplayCar();
        

        }
    }
}
