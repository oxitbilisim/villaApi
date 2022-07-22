using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum TakvimYarimGun
    {
        [Display(Name = "Başta")]
        Basta = 1,
        [Display(Name = "Ortada")]
        Yok = 2,
        [Display(Name = "Sonda")]
        Sonda = 3,
    }
}
