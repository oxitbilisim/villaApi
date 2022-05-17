using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum EtiketAdres
    {
        [Display(Name = "Bölge")]
        Bolge = 1,
        [Display(Name = "Kategori")]
        Kategori = 2,
    }
}
