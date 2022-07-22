using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum RezervasyonDurum
    {
        [Display(Name = "Onaylı")]
        Onayli = 1,
        [Display(Name = "Opsiyon")]
        Opsiyon = 2,
        [Display(Name = "Onay Bekliyor")]
        OnayBekliyor = 3,
        [Display(Name = "İptal")]
        Iptal = 4,
        [Display(Name = "Kapama")]
        Kapama = 5,
    }
}
