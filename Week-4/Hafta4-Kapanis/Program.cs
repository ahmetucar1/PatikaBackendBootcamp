using System;
using System.ComponentModel;
using Name;

namespace Hafta4Kapanis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bilgisayar> bilgisayarlar = new List<Bilgisayar>();
            List<Telefon> telefonlar = new List<Telefon>();

            while (true)
            {
                Console.WriteLine("Bilgisayar eklemek için 1'e - Telefon eklemek için 2'e basın ");
                int karar = Convert.ToInt32(Console.ReadLine());

                if (karar == 1)
                {
                    Bilgisayar yeniBilgisayar = new Bilgisayar();

                    Console.WriteLine("Bilgisayar adı ?");
                    yeniBilgisayar.Ad = Console.ReadLine();

                    Console.WriteLine("Bilgisayarınızın İşletim Sistemi ?");
                    yeniBilgisayar.IsletimSistemi = Console.ReadLine();

                    Console.WriteLine("Kaç Usb girişi var ?");
                    yeniBilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                    Console.WriteLine("Bilgisayar üretildi");
                    bilgisayarlar.Add(yeniBilgisayar);
                }
                else if (karar == 2)
                {
                    Telefon yeniTelefon = new Telefon();

                    Console.WriteLine("Telefon adı ?");
                    yeniTelefon.Ad = Console.ReadLine();

                    Console.WriteLine("Telefonu  İşletim Sistemi ?");
                    yeniTelefon.IsletimSistemi = Console.ReadLine();

                    soru : Console.WriteLine("Telefonun lisansı var mı ? (e/h)");
                    char yanit = Convert.ToChar(Console.ReadLine());
                    if (yanit == 'e')
                        yeniTelefon.LisansliMi = true;
                    else if (yanit == 'h')
                    yeniTelefon.LisansliMi = false;
                    else
                    {
                       Console.WriteLine("Yanlış veri girdiniz");
                       goto soru;
                    }
                    
                    Console.WriteLine("Telefon üretildi");
                    telefonlar.Add(yeniTelefon);
                }
                else
                Console.WriteLine("Yanlış veri girdiniz");

                Console.WriteLine("Ekleme işlemine devam etmek istiyor musunuz? (e/h)");

                char cevap = Convert.ToChar(Console.ReadLine());

                if (cevap == 'h')
                {
                    break;
                }
            }

            Console.WriteLine("---------BİLGİSAYARLAR----------");

            foreach (var bilgisayar in bilgisayarlar)
            {
                bilgisayar.BilgileriYazdir();
                Console.WriteLine("---------");
            }

            Console.WriteLine("----------TELEFONLAR-------------");

            foreach (var telefon in telefonlar)
            {
                telefon.BilgileriYazdir();
                Console.WriteLine("-------");
            }
        }
    }
}
