using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class VillaGosterimDtoC 
    {
        [NotMapped]
        public int? VillaId { get; set; }

        public Gosterim Gosterim { get; set; }
    }
}