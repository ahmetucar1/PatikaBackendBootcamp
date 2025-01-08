using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

namespace Pratik11
{

      public class Person
      {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumTarihi { get; set; }
        public string Gorev { get; set; }

        public void KendiniTanit()
      {
        Console.WriteLine("Merhaba ben " + Ad + " " + Soyad + " " + "Doğum tarihim:" + " " + DogumTarihi + " " + "Görevim:" + " " + Gorev);
      }

      } 
      
}