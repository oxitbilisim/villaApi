using System.ComponentModel.DataAnnotations;

namespace Villa.Domain.Enum
{
    public enum Cinsiyet
    {
        [Display(Name = "Bayan")]
        Bayan = 1,
        [Display(Name = "Erkek")]
        Erkek = 2,
        
    }
}
