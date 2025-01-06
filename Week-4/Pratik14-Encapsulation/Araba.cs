using System;

namespace Encapsulation
{
    //Car class
    public class Car
    {
        private string _marka;
        private string _model;
        private string _color;
        private int _numberDoors;

        //Codes required to read class data from outside
        public Car(string marka, string model, string color, int numberDoors)
        {
            _marka = marka;
            _model = model;
            _color = color;
            _numberDoors = numberDoors;
        }

        //Conditions for the number of doors feature
        public int NumberDoors
        {
            get { return _numberDoors; }

            set{
                if(value != 2 && value != 4)
                {
                    Console.WriteLine("Geçersiz değer girdiniz");
                   _numberDoors = -1;
                }
                else
                {
                    Console.WriteLine($"Kapı sayısı: {_numberDoors}");
                }
            }
        }

       
        //A method written to display the properties of the class on the screen
        public void DisplayCar()
        {
            Console.WriteLine($"Marka: {_marka}\nModel : {_model}\nColor: {_color}\nKapı Sayısı: {_numberDoors}");
        }
    }
}