using System;
using System.Security.Cryptography.X509Certificates;
using Pratice12Class;

namespace Pratice12
{
    class PraticeLibrary
    {
        static void Main(string[] args)
        {
         
        // Default constructor kullanarak nesne oluşturma
            Kitap kitap1 = new Kitap();
            kitap1.Ad = "Adı Aylin";
            kitap1.YazarAdi = "Ayşe";
            kitap1.YazarSoyadi = "Kulin";
            kitap1.SayfaSayisi = 398;
            kitap1.Yayinevi = "Remzi Kitabevi";

            // Parametreli constructor kullanarak nesne oluşturma
            Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

            // Kitap bilgilerini yazdırma
            Console.WriteLine("Kitap 1 Bilgileri:");
            kitap1.BilgileriYazdir();

            Console.WriteLine("\nKitap 2 Bilgileri:");
            kitap2.BilgileriYazdir();
        }
    }
}

//Class : Kitap ve PraticeLibrary birer sınıftır. Sınıflar, bir nesnenin yapısını ve davranışlarını tanımlar. Örneğin, Kitap sınıfı kitap nesnelerinin özelliklerini ve davranışlarını belirler.
//Property: Ad, YazarAdi, YazarSoyadi, SayfaSayisi, Yayinevi, ve KayitTarihi kitap nesnesinin özellikleridir. Bu özellikler, nesnenin verilerini saklamak için kullanılır.
//New: new Kitap() ifadesi, Kitap sınıfından yeni bir nesne oluşturur. Örneğin, Kitap kitap1 = new Kitap(); ifadesi bir kitap nesnesi oluşturur.
//Constructor: Kitap() ve Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinevi) metotları birer constructor’dır. Constructor, bir sınıftan yeni bir nesne oluşturulduğunda çağrılan özel bir metottur. Parametresiz olan varsayılan değerlerle çalışır; parametreli olan ise nesne oluşturulurken belirli değerlerin atanmasını sağlar.
