using System;


namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Yeni Liste tanımlama
            List<string> davetliler = new List<string>();

            //Listeye eleman ekleme
            davetliler.Add("Bülent Ersoy");
            davetliler.Add("Ajda Pekkan");
            davetliler.Add("Ebru Gündeş");
            davetliler.Add("Hadise");
            davetliler.Add("Hande Yener");
            davetliler.Add("Tarkan");
            davetliler.Add("Funda Arar");
            davetliler.Add("Demet Akalın");

            //Listeyi yazdırma
            foreach (var davetli in davetliler)
            {
                Console.WriteLine(davetli);
            }

            //Ek olarak: Kullanıcıdan bir davetli ismi alıp
            Console.WriteLine("Sen de bir tane ekle");
            string yeniDavetli = Console.ReadLine();

            //alınan ismi listeye ekleme
            davetliler.Add(yeniDavetli);

            Console.WriteLine("Yeni Davetli Listesi");

            //Yeni Listeyi yazdırma
            foreach (var davetli in davetliler)
            {
                Console.WriteLine(davetli);
            }

        }
    }
}
