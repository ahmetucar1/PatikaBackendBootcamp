namespace coffee_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Coffee = new List<string>();
            string coffes;

            Console.WriteLine("5 Adet kahve giriniz.");
            for (int i = 0; i < 5; i++)
            {
                coffes = Console.ReadLine();
                Coffee.Add(coffes);
            }
            Console.WriteLine("**Kahveleriniz**");
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(i+1+"-"+Coffee[i]);
            }
        }
    }
}
