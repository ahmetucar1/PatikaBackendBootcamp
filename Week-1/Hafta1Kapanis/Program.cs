using System;

namespace Hafta1Kapanis
{
    class Program
    {
        static void Main(String[] args)
        {

            // 1.Print "Hello Word" on screen!
            Console.WriteLine("Hello Word");


           Console.WriteLine("-----------------------");

            
            //2. Take two integers from the user and print the sum of these numbers to the console.
            Console.WriteLine("Lütfen toplamak istediğiniz iki sayıyı girin.");
            Console.WriteLine("İlk sayıyı girin:");
            string sayiBir = Console.ReadLine();
            int.TryParse(sayiBir, out int sayi1);

           Console.WriteLine("İkinci sayıyı girin:");
           string sayiİki = Console.ReadLine();
           int.TryParse(sayiİki, out int sayi2);

           Console.WriteLine($"Sayılarınızın Toplamı : {sayi1 + sayi2}");  


           Console.WriteLine("-----------------------");

        
        //3. Ask the user for their age. If age is 18 or older, print "You are an Adult", otherwise print "You are a Child".
          Console.WriteLine("Lütfen yaşınızı girin");
          string yasStr = Console.ReadLine();
          int.TryParse(yasStr, out int yas);
        
          if (yas >= 18)
          {
            Console.WriteLine("Maşallah, Yetişkinsiniz");
          }
          else
          {
            Console.WriteLine("Çocuksunuz, Daha göreceğiniz çok şey var.");
          }
         
         

         Console.WriteLine("-----------------------");

         //4. Get an integer from the user. If the number is even, print "Even number", if odd, print "Odd number".
          
            
            Console.WriteLine("Bir tam sayı girin ve girdiğiniz sayı tek mi çift mi görelim.");
            string tamSayiStr = Console.ReadLine();
            int.TryParse(tamSayiStr, out int tamSayi);

            if (tamSayi % 2 == 0)
            {
                Console.WriteLine($" {tamSayi} Çifttir.");
            }
            else
            {
                Console.WriteLine($" {tamSayi} Tektir.");
            }


            

         Console.WriteLine("-----------------------");


        //5.Get a temperature value from the user (in Celsius). If the temperature is less than 0, print "Freezing", if between 0 and 30, print "Normal", if greater than 30, print "Hot".

        Console.WriteLine("Bir Celsius değeri girin ve şu an ısısal anlamda ne alemde olduğunuzu söyleyelim.");
        string celsiusStr = Console.ReadLine();
        int.TryParse(celsiusStr, out int celsius);

        if (celsius < 0)
        {
            Console.WriteLine("Karda donmak üzeresin uyumak tatlı geliyor ama donduğunun farkında değilsin. Donuyor(Issız Adam Repliği)");
        }
        else if (celsius >= 0 && celsius <= 30)
        {
            Console.WriteLine("Gayet normal bir ortamdasın şükret. Normal");
        }
        else
        {
            Console.WriteLine("Abe sıccaxtır geldik buraaa. Sıcak");
        }



         Console.WriteLine("-----------------------");
       
        //6. Get a number from the user between 1 and 7. This number represents one of the days. Print the day names "Monday", "Tuesday", etc. according to the number. Print "Invalid day" when an invalid number is entered.
       
        
        Console.WriteLine("1 - 7 arasında sayı girin ve hangi güne denk geldiğini görün");
        string dayNumberStr = Console.ReadLine();
        int.TryParse(dayNumberStr, out int dayNumber);

        Gunler userNumber = (Gunler)dayNumber;

         if (dayNumber >= 1 && dayNumber <= 7) // Basit kontrol
            {
                Console.WriteLine($"{userNumber}");
            }
            else
            {
                Console.WriteLine("Geçersiz bir seçim yaptınız!");
            }
 
         


         Console.WriteLine("-----------------------");

        // 7. Get a grade (between 0-100) from the user. Print "Pass", "Average", "Fail" according to the grade range. (0-60 fail, 61-80 average, 81-100 pass)
            Console.WriteLine("Notunu gir de seni derecelendirelim.(0-100)");
            string notStr = Console.ReadLine();
            int.TryParse(notStr, out int not);

           switch (not)
            {
                case >= 0 and <= 60:
                    Console.WriteLine("Çok çalışman lazım. Başarısız. Tembel.");
                    break;
                case >= 61 and <= 80:
                    Console.WriteLine("Eh. Fena değil. Orta.");
                    break;
                case >= 81 and <= 100:
                    Console.WriteLine("Aferin. Başarılısın.");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir değer girdin. Daha notun hangi aralıkta olduğunu bile bilmiyorsun.");
                    break;
            }



         Console.WriteLine("-----------------------");



         // 8. Get a month number (1-12) from the user and print how many days this month has. 28 days for February, check the number of days for other months.


            
            Console.WriteLine("Lütfen bir ay numarası giriniz (1-12):");
            int ayNumarasi = Convert.ToInt32(Console.ReadLine());

            if (ayNumarasi >= 1 && ayNumarasi <= 12)
            {
                Aylar secilenAy = (Aylar)ayNumarasi;

                int gunSayisi;
                switch (secilenAy)
                {
                    case Aylar.Şubat:
                        gunSayisi = 28;
                        break;
                    case Aylar.Nisan:
                    case Aylar.Haziran:
                    case Aylar.Eylül:
                    case Aylar.Kasım:
                        gunSayisi = 30;
                        break;
                    default:
                        gunSayisi = 31;
                        break;
                }

                Console.WriteLine($"{secilenAy} ayı {gunSayisi} gündür.");
            }
            else
            {
                Console.WriteLine("Lütfen 1 ile 12 arasında bir sayı giriniz.");
            }


         // 9. Ask the user for a password. If the password is "12345", print "Login Success", otherwise print "Login Fail".


         Console.WriteLine("-----------------------");

         Console.WriteLine("Lütfen şifrenizi girin");
         string sifreStr = Console.ReadLine();
         int.TryParse(sifreStr, out int sifre);

         if (sifre == 1234)
         {
            Console.WriteLine("Giriş Başarılı");
         }
         else{
            Console.WriteLine("Giriş Başarısız");
         }




         Console.WriteLine("-----------------------");


        // 10. Get two numbers and an operation (+, -, *, /) from the user. Calculate and print the result according to the selected operation. If an invalid operation is entered, print "Invalid operation".

        Console.WriteLine("Lütfen iki sayı ve bu sayılarla yapmak istediğiniz (+,-,*,/) işlemi girin.");

        Console.WriteLine("Birinci sayıyı girin.");
        string number1Str = Console.ReadLine();
        int.TryParse(number1Str, out int number1);

        Console.WriteLine("İkinci sayıyı girin.");
        string number2Str = Console.ReadLine();
        int.TryParse(number2Str, out int number2);

        Console.WriteLine("Yapmak istediğiniz işlemi(+,-,*,/) girin.");

        string islem = Console.ReadLine();

       switch (islem)
       {
        case "+" :
        Console.WriteLine($"Sayılarınızın toplamı: {number1 + number2}");
        break;

        case "-" :
        Console.WriteLine($"Sayılarınızın farkı: {number1 - number2}");
        break;

        case "*" :
        Console.WriteLine($"Sayılarınızın çarpımı: {number1 * number2}");
        break;

        case "/" :
         // Bölme işlemi sırasında sıfıra bölmeyi kontrol et
        if (number2 != 0)
        {
            Console.WriteLine($"Sayılarınızın bölümü: {number1 / (double)number2}");
        }
        else
        {
            Console.WriteLine("Hata: Bir sayı sıfıra bölünemez.");
        }
        break;
       
       default:
        Console.WriteLine("Geçersiz işlem.");
        break;

       
       }

          }
       
        }
    }


enum Gunler 
        {
            Pazartesi = 1,
            Salı = 2,
            Çarşamba = 3,
            Perşembe = 4,
            Cuma = 5,
            Cumartesi = 6,
            Pazar = 7
        }

 enum Aylar
        {
            Ocak = 1,
            Şubat = 2,
            Mart = 3,
            Nisan = 4,
            Mayıs = 5,
            Haziran = 6,
            Temmuz = 7,
            Ağustos = 8,
            Eylül = 9,
            Ekim = 10,
            Kasım = 11,
            Aralık = 12
        }        