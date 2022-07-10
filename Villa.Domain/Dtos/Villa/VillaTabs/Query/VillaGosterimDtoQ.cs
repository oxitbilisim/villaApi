using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Dtos
{
    public class VillaGosterimDtoQ 
    {
        [NotMapped]
        public int? VillaId { get; set; }
        public string Gosterim { get; set; }
    }
}