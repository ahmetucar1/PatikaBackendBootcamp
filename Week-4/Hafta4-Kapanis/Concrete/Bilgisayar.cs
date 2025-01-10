using OOPTEKPROJEDE.Abstract;

namespace Name
{
    internal class Bilgisayar : BaseMakine, IBilgisayar
    {
        //public int UsbGirisSayisi { get; set; }

        int _usbGirisSayisi;

        public int UsbGirisSayisi {
            get 
            {
             return _usbGirisSayisi;
            }
            set
            {
                if(value == 2 || value == 4)
              _usbGirisSayisi = value;
              else
              _usbGirisSayisi = -1;
            }
        }
        public bool BluetoothVarMi { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine("Usb Giriş Sayısı: " + UsbGirisSayisi);
            Console.WriteLine(BluetoothVarMi ? "Bluetooth Var" : "Bluetooth Yok");
        }

        public void InterneteBaglan()
        {
            Console.WriteLine("İnternete Bağlanıyor..");
        }

        public void OyunOyna()
        {
            Console.WriteLine("Oyun açılıyor");
        }

        public string TokenUret()
        {
            return "Token Üretildi";
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine("Bilgisayar adı :" + Ad);
        }
    }
}