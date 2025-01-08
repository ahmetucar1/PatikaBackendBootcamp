using System;
using Pratice17Abstraction;

namespace Pratice17
{
    class Program
    {
        public static void Main(string[] args)
        {
            YazilimGelistirici yazilimci = new YazilimGelistirici
            {
                Name = "Ahmet",
                Surname = "Yılmaz",
                Department = "Yazılım"
            };

            ProjeYoneticisi yonetici = new ProjeYoneticisi
            {
                Name = "Hasan",
                Surname = "Çıldırmış",
                Department = "Proje Yönetimi"
            };

            SatisTemsilcisi temsilci = new SatisTemsilcisi
            {
                Name = "Ayşe",
                Surname = "Kara",
                Department = "Satış"
            };

            yazilimci.Position(); 
            yonetici.Position(); 
            temsilci.Position();
        }
    }
}

