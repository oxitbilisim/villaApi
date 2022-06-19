using Villa.Domain.Entities;

namespace Villa.Domain.Dtos
{
    public class VillaPeriyodikFiyatAyarlariDtoC 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public int ParaBirimiId { get; set; }
        public int Komisyon { get; set; }
        public int Kapora { get; set; }
        public decimal Depozito { get; set; }
        public decimal TemizlikUcreti { get; set;} 
        public decimal MinumumUcret { get; set; }
        public bool KrediKartTahsilat { get; set;}
    }
}