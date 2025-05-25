using System.Globalization;
using System.Net.WebSockets; 
using Teknoloji_Magzası;

string secim2; // Kullanıcının uygulamayı tekrar çalıştırmak isteyip istemediği tutulur

// Uygulama döngüsü
do
{
    Console.WriteLine("Uygulamaya Hoşgeldiniz İstediğiniz ürünü Seçiniz");
    Console.WriteLine("1.telefon");
    Console.WriteLine("2.Bilgisayar");
    string secim = Console.ReadLine(); // Kullanıcının ürün seçimi alınır

    // Kullanıcı telefon seçtiyse
    if (secim == "1")
    {
        Console.WriteLine("ürün adı");
        string ad = Console.ReadLine();

        Console.WriteLine("SeriNumarası : ");
        int seriNum;
        // Sayı girilene kadar kullanıcıdan tekrar giriş istenir
        while (!int.TryParse(Console.ReadLine(), out seriNum))
        {
            Console.WriteLine("Tekrar Giriniz");
        }

        Console.WriteLine("İşletim sistemi : ");
        string isletimSistemi = Console.ReadLine();

        Console.WriteLine("Açıklama : ");
        string acıklama = Console.ReadLine();

        Console.WriteLine("Cihaz yurtdışından mı ? : ");
        string cihazDurum = Console.ReadLine();

        // Telefon nesnesi oluşturuluyor ve özellikleri atanıyor
        Telefon telefon = new Telefon
        {
            _ad = ad,
            _seriNumarası = seriNum,
            _isletimSistemi = isletimSistemi,
            _aciklama = acıklama,
            _cihazdurumu = cihazDurum
        };

        // Ürün adı ve bilgileri yazdırılıyor
        telefon.UrunAdiGetir();
        telefon.BilgileriYazidir();
    }

    // Kullanıcı bilgisayar seçtiyse
    else if (secim == "2")
    {
        Console.WriteLine("ürün adı");
        string ad = Console.ReadLine();

        Console.WriteLine("SeriNumarası : ");
        int seriNum;
        // Sayı girilene kadar kullanıcıdan tekrar giriş istenir
        while (!int.TryParse(Console.ReadLine(), out seriNum))
        {
            Console.WriteLine("Tekrar Giriniz");
        }

        Console.WriteLine("İşletim sistemi : ");
        string isletimSistemi = Console.ReadLine();

        Console.WriteLine("Açıklama : ");
        string acıklama = Console.ReadLine();

        Console.WriteLine("Usb Sayısı : ");
        int usbSayısı;
        // USB sayısı da doğrulanarak alınır
        while (!int.TryParse(Console.ReadLine(), out usbSayısı))
        {
            Console.WriteLine("Tekrar Giriniz");
        }

        // Bilgisayar nesnesi oluşturuluyor
        Bilgisayar pc = new Bilgisayar
        {
            _ad = ad,
            _seriNumarası = seriNum,
            _isletimSistemi = isletimSistemi,
            _aciklama = acıklama,
            usb = usbSayısı
        };

        pc.UrunAdiGetir();
        pc.BilgileriYazidir();
    }

    // Uygulama tekrar çalıştırılacak mı?
    Console.WriteLine("Tekrar çalıştırmak ister misiniz? evet/hayır");
    secim2 = Console.ReadLine().ToLower().Trim();

    // Geçersiz giriş kontrolü
    while (secim2 != "evet" && secim2 != "hayır")
    {
        Console.WriteLine("Geçerli Giriş Yapınız");
        secim2 = Console.ReadLine();
    }

    // Eğer kullanıcı "hayır" dediyse çıkış yapılır
    if (secim2 == "hayır")
    {
        break;
    }

} while (secim2 == "evet"); // Kullanıcı "evet" dediği sürece döngü devam eder

