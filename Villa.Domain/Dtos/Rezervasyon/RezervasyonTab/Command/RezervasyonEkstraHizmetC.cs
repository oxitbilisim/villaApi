using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Dtos
{
    public class RezervasyonEkstraHizmetC 
    {
        [NotMapped]
        public int? RezervasyonId { get; set; }
        public int EkstraHizmetId { get; set; }
    }
}