using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum DepozitoDurum
    {
        [Display(Name = "Alınmadı")]
        Alinmadi = 1,
        [Display(Name = "Alındı")]
        Alindi = 2,
        [Display(Name = "İade Edildi")]
        IadeEdildi = 3,
     
    }
}
