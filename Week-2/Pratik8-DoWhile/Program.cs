using System;

namespace Pratik8
{
    class Program
    {
        static void Main(string[] args) 
        {
           
         Console.Write("Limit : ");
         int.TryParse(Console.ReadLine(), out int limit);

         int i = 0;
         while (i <= limit)
        {
         Console.WriteLine("Ben bir Patika'lıyım");
         i++;
        }
        
 
        Console.WriteLine("Limit girin: ");
        int.TryParse(Console.ReadLine(), out int limit);

        int j = 0;
        do
        {
         Console.WriteLine("Ben bir Patika'lıyım");
         j++;
        
        } while (j <= limit);

        // While döngüsü koşulu baştan kontrol eder, bu yüzden koşul sağlanmazsa hiç çalışmaz.
        // Do-While döngüsü ise en az bir kez çalışır, sonra koşulu kontrol eder.


        }
    }
}

