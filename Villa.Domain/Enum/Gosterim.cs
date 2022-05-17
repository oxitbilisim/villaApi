using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum Gosterim
    {
        [Display(Name = "Anasayfa")]
        Anasayfa = 1,
        [Display(Name = "Öneçıkan")]
        Önecikan = 2,
        [Display(Name = "Slider")]
        Slider = 3,
        [Display(Name = "Özel")]
        Ozel = 4,
    }
}
