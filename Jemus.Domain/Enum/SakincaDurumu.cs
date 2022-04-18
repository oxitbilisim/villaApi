using System.ComponentModel.DataAnnotations;

namespace Jemus.Domain.Enum
{
    public enum SakincaDurumu
    {
        [Display(Name = "Sakınca Kaydı Yok")]
        SakincaKaydiYok = 1,
        [Display(Name = "Haciz Yakalamalı")]
        HacizYakalamali = 2,
        [Display(Name = "Araç Aranıyor")]
        AracAraniyor = 3,
        [Display(Name = "Tescilsiz Araç")]
        TescilsizArac = 4,
        [Display(Name = "Plaka Kayıp")]
        PlakaKayip = 5,
        [Display(Name = "Plaka Çalıntı")]
        PlakaCalinti = 6,
        [Display(Name = "Araç Trafikten Men")]
        AracTrafiktenMen = 7,
        [Display(Name = "Marka Renk Uyumsuzluğu")]
        MarkaRenkUyumsuzlugu = 8,
        [Display(Name = "Araç Çalıntı")]
        AracCalinti = 9,
        [Display(Name = "Tescil Dönüşü Bekleniyor")]
        TescilDonusuBekleniyor = 10
            
    }
}
