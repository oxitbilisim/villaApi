using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class RezervasyonEntryDtoQ
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        public string VillaAd  { get; set; }

        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string MusteriAdSoyad { get; set; }
        public string Not { get; set; }
    }
}