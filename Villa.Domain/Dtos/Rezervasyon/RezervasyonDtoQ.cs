using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class RezervasyonDtoQ
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string MusteriAdSoyad { get; set; }
        
        public int? MSYetiskin { get; set; }
        public int? MSCocuk { get; set; }
        public int? MSBebek { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
        public string Not { get; set; }
    }
}