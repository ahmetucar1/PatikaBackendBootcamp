

namespace BebekConstructor
{
     public class Bebek
     {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public Bebek()
        {
            Console.WriteLine("Ingaaaaa");
            DogumTarihi = DateTime.Now;
        }
        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            Console.WriteLine(" Ingaaaa ");
        }
     }

}