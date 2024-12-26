using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Meltem Market'e Hoş Geldiniz!");
        Console.WriteLine("Elma = 5 TL");
        Console.WriteLine("Kiraz = 7 TL");
        Console.WriteLine("Çilek = 6 TL");
        Console.WriteLine("Muz = 5 TL");
        Console.WriteLine("Diğer bütün meyveler = 8 TL");

        // Kullanıcıdan meyve seçimi alıyoruz.
        Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Kiraz/Çilek/Muz/Diğer): ");
        string secim = Console.ReadLine().ToLower(); // Büyük/küçük harf duyarlılığını kaldırıyoruz.

        // If ile geçersiz giriş kontrolü
        if (string.IsNullOrWhiteSpace(secim))
        {
            Console.WriteLine("Geçersiz bir giriş yaptınız, lütfen bir meyve adı giriniz!");
            return;
        }

        // Switch ile çözüm
        Console.WriteLine("\n--- Switch Yapısıyla Çözüm ---");
        string meyveAdi = ""; // Seçilen meyvenin adı
        int fiyat = 0;        // Seçilen meyvenin fiyatı

        switch (secim)
        {
            case "elma":
                meyveAdi = "Elma";
                fiyat = 5;
                break;
            case "kiraz":
                meyveAdi = "Kiraz";
                fiyat = 7;
                break;
            case "çilek":
                meyveAdi = "Çilek";
                fiyat = 6;
                break;
            case "muz":
                meyveAdi = "Muz";
                fiyat = 5;
                break;
            default:
                meyveAdi = "Diğer";
                fiyat = 8;
                break;
        }

        Console.WriteLine($"Seçtiğiniz meyve: {meyveAdi}, Fiyatı: {fiyat} TL");
    }
}