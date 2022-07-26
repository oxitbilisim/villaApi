using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum Menus
    {
        [Display(Name = "Destek")]
        Destek = 1,
        [Display(Name = "Bilgilendirme")]
        Bilgilendirme = 2,
        [Display(Name = "Kurumsal")]
        Kurumsal = 3,
    }
}
