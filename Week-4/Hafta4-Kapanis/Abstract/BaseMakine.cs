namespace OOPTEKPROJEDE.Abstract
{
    internal abstract class BaseMakine
    {
        protected BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime UretimTarihi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Üretim Tarihi :" + UretimTarihi);
            Console.WriteLine("Ad :" + Ad);
            Console.WriteLine("Aciklama :" + Aciklama);
            Console.WriteLine("İşletim Sistemi :" + IsletimSistemi);
        }

        public abstract void UrunAdiGetir();
    }
    
}