using System;

namespace WhilePratikleri {
    class Program {
        static void Main(string[] args) {

        //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
        
        int i = 0;

        while (i < 10)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            i++;
        }
        
    
        Console.WriteLine("---------------------------");


        // 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

        int j = 1;

        while (j <= 20)
        {
            Console.WriteLine(j);
            j++;
        }

        
        Console.WriteLine("---------------------------");

        // 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

        int k = 1;

        while (k <= 20)
        {
            if (k % 2 == 0)
                Console.WriteLine(k);

                k++;
        } 
    
        //Farklı Bir yöntemle
       Console.WriteLine("İkinci Yöntem");

        int l = 2;

        while (l <= 20)
         {
            Console.WriteLine(l);
        
            l += 2;
         }

         
        Console.WriteLine("---------------------------");


         //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız!
         
         int toplam = 0;
         int m = 50;
         
         while (m <= 150)
         {
            toplam += m;
            m++;
         }
         Console.WriteLine(toplam);


        
        Console.WriteLine("---------------------------");

        
        //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
        
        int singleNum = 0;
        int pairNum   = 0;

        int n = 1;

        while (n <= 120)
        {
            if (n % 2 == 1)
            {
                singleNum += n;
            }
            else (n % 2 == 0)
            {
                pairNum += n;
            }
            n++;
        }
        Console.WriteLine("Tek sayıların sayısı: " + singleNum);
        Console.WriteLine("Çift sayıların sayısı: " + pairNum);

        }
    }
}
