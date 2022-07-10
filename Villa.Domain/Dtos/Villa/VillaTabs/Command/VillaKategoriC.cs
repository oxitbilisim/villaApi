using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Dtos
{
    public class VillaKategoriDtoC 
    {
        [NotMapped]
        public int? VillaId { get; set; }
        public int KategoriId { get; set; }
    }
}