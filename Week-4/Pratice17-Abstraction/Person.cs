namespace Pratice17Abstraction
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        public abstract void Position(); 
    }

    public class YazilimGelistirici : Person
    {
        public override void Position()
        {
            Console.WriteLine($"Merhaba, Ben {Name} {Surname}, {Department} departmanındayım. Yazılım geliştirici olarak çalışıyorum.");
        }
    }

    public class ProjeYoneticisi : Person
    {
        public override void Position()
        {
            Console.WriteLine($"Merhaba, Ben {Name} {Surname}, {Department} departmanındayım. Proje yöneticisi olarak çalışıyorum.");
        }
    }

    public class SatisTemsilcisi : Person
    {
        public override void Position()
        {
            Console.WriteLine($"Merhaba, Ben {Name} {Surname}, {Department} departmanındayım. Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
