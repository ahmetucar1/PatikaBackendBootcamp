using System;
using System.Collections;
using BebekConstructor;

namespace Constructor
{
    class Pratice11
    {
        static void Main(String[] args)
        {

           Bebek bebek1 = new Bebek();
           Bebek bebek2 = new Bebek(" Ali ", " Uçar ");

           Console.WriteLine(bebek1.DogumTarihi);
           Console.WriteLine(bebek2.Ad + bebek2.Soyad);

        }
    }
}