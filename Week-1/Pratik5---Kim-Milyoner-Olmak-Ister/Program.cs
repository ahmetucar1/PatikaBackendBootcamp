using System;

namespace KimMilyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogruCevapSayisi = 0;

            // 1. Soru
            Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
            Console.WriteLine("a) Lama");
            Console.WriteLine("b) Deve");
            string cevap1 = Console.ReadLine().ToLower(); // Büyük-Küçük harf duyarlılığını uyguladık  

            if (cevap1 == "a")
            {
                dogruCevapSayisi++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap.");
            }

            // 2. Soru
            Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?");
            Console.WriteLine("a) Venüs");
            Console.WriteLine("b) Mars");
            string cevap2 = Console.ReadLine().ToLower();

            if (cevap2 == "a")
            {
                dogruCevapSayisi++;
                Console.WriteLine("Doğru cevap!");
            }
            else
            {
                Console.WriteLine("Yanlış cevap.");
            }

            // 3. Soru (Yalnızca büyük ödül ihtimali varsa sorulur)
            if (dogruCevapSayisi >= 1) // İlk iki sorudan en az birini doğru cevaplamışsa
            {
                Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
                Console.WriteLine("a) 7");
                Console.WriteLine("b) 12");
                string cevap3 = Console.ReadLine().ToLower();

                if (cevap3 == "b")
                {
                    dogruCevapSayisi++;
                    Console.WriteLine("Doğru cevap!");
                }
                else
                {
                    Console.WriteLine("Yanlış cevap.");
                }
            }
            else
            {
                Console.WriteLine("İlk iki soruda yeterli doğru cevap alamadığınız için üçüncü soruya geçilemiyor.");
            }

            // Sonuç
            if (dogruCevapSayisi >= 2)
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL kazandınız!");
            }
            else
            {
                Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
            }
        }
    }
}

