using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class RezervasyonEntryDtoQ
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        public string VillaAd  { get; set; }

        public DateTimeOffset Baslangic { get; set; }
        public DateTimeOffset Bitis { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string Not { get; set; }
    }
}