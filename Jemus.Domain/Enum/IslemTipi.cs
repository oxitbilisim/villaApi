using System.ComponentModel.DataAnnotations;

namespace Jemus.Domain.Enum
{
    public enum IslemTipi
    {
        [Display(Name = "Yakalanamadı")]
        Yakalanamadi = 1,
        [Display(Name = "Yakalandı")]
        Yakalandi = 2,
        [Display(Name = "Hatalı Tespit")]
        HataliTespit = 3,
        [Display(Name = "İlgili Makama Bildirildi")]
        IlgiliMakamaBildirildi = 4,
        [Display(Name = "İşlem Yapılmadı")]
        IslemYapilmadi = 5,
              [Display(Name = "Plaka Güncellendi")]
        PlakaGuncellendi = 6
           
    }
}
