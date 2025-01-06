using System;

namespace TravelCompanionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Kullanıcının tatilini seçmesi için döngü başlatıyoruz.
            {
                Console.WriteLine("Hoşgeldiniz. Beraber tatilinizi planlamaya başlayalım.");
                Console.WriteLine("Nereye gitmek istersiniz? Seçeneklerimiz: Bodrum, Marmaris, Çeşme");

                string lokasyon;
                string suggestion = "";
                int price = 0;

                while (true) // Lokasyon seçimi için döngü başlatıyoruz.
                {
                    Console.WriteLine("Lütfen bir yer seçin: Bodrum, Marmaris, Çeşme");
                    lokasyon = Console.ReadLine().ToLower();

                    switch (lokasyon)
                    {
                        case "bodrum":
                            lokasyon = "Bodrum";
                            price = 4000;
                            suggestion = "Bodrum tatilinde, berrak denizlerde yüzüp güneşlenebilir, popüler plajlarda keyifli vakit geçirebilirsiniz.";
                            break;

                        case "marmaris":
                            lokasyon = "Marmaris";
                            price = 3000;
                            suggestion = "Marmaris'te eşsiz koylarda yüzebilir, tekne turlarına katılarak cennet köşelerini keşfedebilirsiniz.";
                            break;

                        case "çeşme":
                            lokasyon = "Çeşme";
                            price = 5000;
                            suggestion = "Çeşme'de berrak denizlerde yüzebilir, Alaçatı'nın taş sokaklarında gezebilirsiniz.";
                            break;

                        default:
                            Console.WriteLine("Hatalı giriş yaptınız. Seçenekler: Bodrum, Marmaris veya Çeşme yazabilirsiniz.");
                            continue;
                    }
                    break; // Doğru seçim yapıldığında döngüden çıkıyoruz.
                }

                Console.WriteLine($"Gitmek istediğiniz yer: {lokasyon}. {suggestion}");
                Console.WriteLine("Kaç kişi için tatil planı istiyorsunuz?");
                int kisiSayisi;

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir değer girin. Kaç kişisiniz?");
                    }
                }
                
                // Kullanıcının ulaşım yolu seçimini alalım.
                Console.WriteLine("Nasıl gitmek istersiniz:");
                Console.WriteLine("1 - Kara yolu: Kişi başı 1500 TL");
                Console.WriteLine("2 - Hava yolu: Kişi başı 4000 TL");
                int ulasimFiyati = 0;

                while (true) //Seçim için döngü başlatıyoruz.
                {
                    string ulasimYolu = Console.ReadLine();

                    if (ulasimYolu == "1")
                    {
                        ulasimFiyati = 1500;
                        break;
                    }
                    else if (ulasimYolu == "2")
                    {
                        ulasimFiyati = 4000;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz değer girdiniz. 1 veya 2 olarak seçim yapınız.");
                    }
                }
                //Kullanıcıya seçimlerini toplu halde verip farklı planı olup olmadığını soruyoruz. Farklı bir planı varsa döngü en başa sarar.
                int toplamFiyat = (price + ulasimFiyati) * kisiSayisi;
                Console.WriteLine($"\nSeçtiğiniz lokasyon: {lokasyon}\nLokasyonda yapılabilecekler: {suggestion} \nKişi sayısı: {kisiSayisi}\nTatilin toplam maliyeti: {toplamFiyat} TL\n");

                Console.WriteLine("Başka bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
                string devamSa = Console.ReadLine().ToLower();

                if (devamSa != "evet")
                {
                    Console.WriteLine("İyi Tatiller!");
                    break;
                }
            }
        }
    }
}
