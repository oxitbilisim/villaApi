using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class KapamaDtoQ
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        public string VillaAd  { get; set; }

        public DateTimeOffset Baslangic { get; set; }
        public DateTimeOffset Bitis { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }

        public Boolean OpenState { get; set; }
        public string Not { get; set; }
    }
}