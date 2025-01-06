using System;

namespace ForPractices
{
    class Program
    {
        static void Main(string[] args)
        {

        // Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız./
          for (int i = 0; i < 10; i++)
          {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
          }

          Console.WriteLine("----------------------------");

          //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
          for (int j = 1; j <= 20; j++)
          {
            Console.WriteLine(j);
          }

          Console.WriteLine("----------------------------");

          for (int k = 2; k <= 20 ; k += 2)
              Console.WriteLine(k);

         //2. Yöntem
  
         Console.WriteLine("2. Yöntem");
         Console.WriteLine("----------------------------");

         for (int l = 1; l < 21; l++)
         {
            if (l % 2 == 0)
            {
                Console.WriteLine(l);
            }
         }
         
         Console.WriteLine("----------------------------");
         // 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
        
        int total = 50;

        for (int m = 50; m <= 150; m++)
        {
            total += m;
            m++;
        }
        Console.WriteLine($"Toplam: {total}");
        


         Console.WriteLine("----------------------------");

        //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        int singleTotal = 0;
        int pairTotal   = 0;

        for (int n = 1; n < 121; n++)
        {
            if (n % 2 == 1)
            
                singleTotal = singleTotal + n;

        }
        Console.WriteLine("1-120 arasındaki tek sayıların toplamı:" + singleTotal);


        for (int o = 1; o < 121; o++)
        {
            if (o % 2 == 0)
            
                pairTotal = pairTotal + o;

        }
        Console.WriteLine("1-120 arasındaki çift sayıların toplamı:" + pairTotal);
        }
    }
}




