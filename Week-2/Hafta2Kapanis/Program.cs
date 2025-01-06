using System;

namespace Hafta2Kapanis
{
    class Program
    {
        static void Main (String[] args)
        {
        //1. Aşağıdaki çıktıyı yazan bir program.
        //Merhaba
        //Nasılsın ?
        //İyiyim
        //Sen nasılsın ?
        Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?"); // \n işareti ile kelimeleri alt satırlara taşıdık.

        Console.WriteLine("--------------------");

        //2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

        string name = "Ahmet"; 
        int yas = 26;

        Console.WriteLine($"Metinsle ifade: {name}\nTam sayı ifadesi {yas}");

        Console.WriteLine("--------------------");

        //3 - Rastgele bir sayı üretip , ekrana yazdırınız.

        void RastgeleSayi()
        {
            Random random = new Random();
            int randomNumber = random.Next();
            Console.WriteLine($"Random sayı : {randomNumber}");
        }
        RastgeleSayi();

        Console.WriteLine("--------------------");

        //4. Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
        
        void RandomSayiMod()
        {
            Random random = new Random();
            int randomNumber = random.Next() % 3;
            Console.WriteLine($"Rastgele üretilen sayının 3' e bölümünden kalanı: {randomNumber}");
        }
        RandomSayiMod();
        
        //5.Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

        Console.WriteLine("--------------------");

        Console.WriteLine("Lütfen yaşınızı girin");

        int.TryParse(Console.ReadLine(), out int age);

        if (age < 18)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("+");
        }

        Console.WriteLine("--------------------");

        // Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        void SozYazdır()
        {
         Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }        
        for (int i = 0; i < 10; i++)
        {
        SozYazdır();
        }

        Console.WriteLine("--------------------");

        // 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
        Console.WriteLine("Lütfen yerlerini değiştirmek istediğiniz iki isim giriniz");

        Console.WriteLine("Birinci isim girin");
        string metin1 = Console.ReadLine();
        Console.WriteLine("İkinci isim girin");
        string metin2 = Console.ReadLine();

        string geciciDegisken = metin1;
        metin1 = metin2;
        metin2 = geciciDegisken;

        Console.WriteLine($"Önceki\r\nisim 1 : {metin1}\r\nİsim 2 : {metin2}");

        Console.WriteLine("--------------------");

        //8. Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

        void BenDegerDondurmem()
        {
            Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
        }
        BenDegerDondurmem();

        Console.WriteLine("--------------------");
        
        //9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

        void Topla(int a, int b)
        {
          int toplam = a + b;
          Console.WriteLine($"Toplam: {toplam}");
        }
        Topla(5,3);

       Console.WriteLine("--------------------");

       //10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
       
        Console.WriteLine("Lütfen true ya da false değerini giriniz:");
        string girdi = Console.ReadLine();

        if (bool.TryParse(girdi, out bool userValue))
        {
            string result = BoolToString(userValue);
            Console.WriteLine($"Sonuç: {result}");
        }
        else
        {
            Console.WriteLine("Hata: Geçersiz giriş yaptınız. Lütfen 'true' veya 'false' giriniz.");
        }
    }

    //11. Kullanıcıdan alınan bool değeri string döndüren metot
    static string BoolToString(bool value)
    {
        switch (value)
        {
            case true:
                return "Doğru";
            case false:
                return "Yanlış";
            default:
                return "Hata: Geçersiz değer."; // Bu durum normalde çalışmaz çünkü sadece bool değerleri kontrol ediliyor.
        }
        
        // 12. 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

        Console.WriteLine("--------------------");

        Console.WriteLine("Birinci kişinin yaşını giriniz:");
        int yas1 = int.Parse(Console.ReadLine());

        Console.WriteLine("İkinci kişinin yaşını giriniz:");
        int yas2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Üçüncü kişinin yaşını giriniz:");
        int yas3 = int.Parse(Console.ReadLine());

        int enYasli = EnYasliBul(yas1, yas2, yas3);
        Console.WriteLine($"En yaşlı kişinin yaşı: {enYasli}");

         static int EnYasliBul(int yas1, int yas2, int yas3)
    {
        // Math.Max kullanarak en büyük değeri buluyoruz
        return Math.Max(yas1, Math.Max(yas2, yas3));
    }

    Console.WriteLine("--------------------");
     
    //12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
       
        int maxNumber = int.MinValue;  // En küçük değeri atıyoruz, böylece ilk sayı her zaman daha büyük olur.
        
        while (true)
        {
            Console.Write("Bir sayı girin: ");
            string userDeger = Console.ReadLine();


            if (int.TryParse(userDeger, out int number))
            {

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                Console.WriteLine("Şu ana kadar girilen en büyük sayı: " + maxNumber);
            }
            else
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz. Lütfen tekrar deneyin.");
            }
        }
    
        Console.WriteLine("--------------------");

        //13. Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

        Console.WriteLine("Lütfen ilk ismi giriniz:");
        string isim1 = Console.ReadLine();

        Console.WriteLine("Lütfen ikinci ismi giriniz:");
        string isim2 = Console.ReadLine();

        YerDegistir(ref isim1, ref isim2);

        Console.WriteLine("İsimler yer değiştirildi:");
        Console.WriteLine($"Birinci isim: {isim1}");
        Console.WriteLine($"İkinci isim: {isim2}");

        static void YerDegistir(ref string isim1, ref string isim2)
        {
        string temp = isim1; 
        isim1 = isim2;    
        isim2 = temp;  
        }
        
        Console.WriteLine("--------------------");

        //14. Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

        Console.WriteLine("Lütfen bir sayı girin:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int a))
        {
            Console.WriteLine(TrueFalse(a));
        }
        else
        {
            Console.WriteLine("Geçersiz bir ifade girdiniz. Lütfen bir sayı girin.");
        }
       
       static bool TrueFalse(int a)
        {
        return a % 2 == 0;
        }
        
        Console.WriteLine("--------------------");

        //15. Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

        Console.WriteLine("Gittiğiniz mesafeyi hesaplayalım.\nÖnce Hız bilgisi girin.");
        string hiz = Console.ReadLine();

        Console.WriteLine("Şimdi de zaman bilgisi girin.");
        string zaman = Console.ReadLine();

         if (int.TryParse(hiz, out int speed) && int.TryParse(zaman, out int time))
        {
            Console.WriteLine($"Mesafeniz: {GidilenYol()}");
        }
        else
        {
            Console.WriteLine("Geçersiz bir ifade girdiniz. Lütfen bir sayı değeri girin.");
        }

        int GidilenYol() 
        {
          return speed * time;
        }
        
        Console.WriteLine("--------------------");
        //16. Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        
        double yaricap = 5.0; 
        double alan = AlanHesapla(yaricap);

        Console.WriteLine($"Yarıçapı {yaricap} olan dairenin alanı: {alan}");

        static double AlanHesapla(double yaricap)
        {
         return 3.4 * Math.Pow(yaricap, 2);
        }

        
        Console.WriteLine("--------------------");

        //17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

       string cumle = "Zaman bir GeRi SayIm";
       Console.WriteLine(cumle.ToLower());
       Console.WriteLine(cumle.ToUpper());

    
        Console.WriteLine("--------------------");

        //18. "   Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

        string selam = "    Selamlar   ";
        selam = selam.Trim();
        Console.WriteLine(selam);

        }  
    }
}
