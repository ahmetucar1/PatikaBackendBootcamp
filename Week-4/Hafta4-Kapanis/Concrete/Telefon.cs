using Name;
using OOPTEKPROJEDE.Abstract;

namespace OOPTEKPROJEDE
{
    internal class Telefon : BaseMakine, ITelefon
    {
        public bool LisansliMi { get; set; }

        public void AramaYap()
        {
            Console.WriteLine("Arama yapılıyor..");
        }
        public void MesajGonder()
        {
            Console.WriteLine("Mesaj gönderiliyor..");
        }

        public void MuzikCal()
        {
            Console.WriteLine("Müzik açılıyor..");
        }


        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine(LisansliMi ? "Lisanslı" : "Lisanssız");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Telofun Adı :" + Ad);
        }
    }
}