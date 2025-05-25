using System;

namespace Teknoloji_Magzası
{
    // Ortak özelliklere sahip soyut sınıf
    public abstract class Makine
    {
        public string _ad { get; set; }
        public int _seriNumarası { get; set; }
        public string _aciklama { get; set; }
        public string _isletimSistemi { get; set; }
        public DateTime _uretimTarihi { get; } // Sadece okunabilir üretim tarihi

        public Makine()
        {
            _uretimTarihi = DateTime.Now; // Otomatik üretim tarihi atanır
        }

        public abstract void UrunAdiGetir(); // Alt sınıflar tarafından zorunlu doldurulacak metod

        public virtual void BilgileriYazidir()
        {
            // Ürüne ait genel bilgileri yazdırır
            Console.WriteLine($"Cihazın Adı : {_ad}");
            Console.WriteLine($"Cihazın Seri Numarası : {_seriNumarası}");
            Console.WriteLine($"Cihazın İşletim Sistemi : {_isletimSistemi}");
            Console.WriteLine($"Ürün Açıklaması : {_aciklama}");
            Console.WriteLine($"Oluşturulma Tarihi : {_uretimTarihi}");
        }
    }

    // Telefon sınıfı
    public class Telefon : Makine
    {
        public string _cihazdurumu { get; set; } // Cihaz yurt dışı mı?

        // Genel bilgilerin yanı sıra cihaz durumunu da yazdırır
        public override void BilgileriYazidir()
        {
            base.BilgileriYazidir();
            Console.WriteLine($"Cihaz yurtdışı mı : {_cihazdurumu}");
        }

        // Ürün adını konsola yazdırır
        public override void UrunAdiGetir()
        {
            Console.WriteLine("Ürün Adı : " + _ad);
        }
    }

    // Bilgisayar sınıfı
    public class Bilgisayar : Makine
    {
        private int _usb; // USB sayısı özel alan

        // USB sayısını sadece 2 veya 4 olarak kabul eder, aksi halde -1
        public int usb
        {
            get { return _usb; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usb = value;
                }
                else
                {
                    _usb = -1; // Geçersiz giriş
                }
            }
        }

        // Ürün adını konsola yazdırır
        public override void UrunAdiGetir()
        {
            Console.WriteLine("Ürün Adı : " + _ad);
        }

        // Bilgisayar bilgilerini yazdırır
        public override void BilgileriYazidir()
        {
            base.BilgileriYazidir();
            Console.WriteLine($"Usb Sayısı : {_usb}");
        }
    }
}
