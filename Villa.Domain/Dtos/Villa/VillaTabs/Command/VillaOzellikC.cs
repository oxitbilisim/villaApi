using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Dtos
{
    public class VillaOzellikDtoC 
    {
        [NotMapped]
        public int? VillaId { get; set; }
        public int OzellikId { get; set; }
    }
}