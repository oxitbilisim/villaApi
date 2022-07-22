using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class TakvimRezarvasyonDtoQ
    {
        public DateTimeOffset Baslangic { get; set; }
        public DateTimeOffset Bitis { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
    }
}