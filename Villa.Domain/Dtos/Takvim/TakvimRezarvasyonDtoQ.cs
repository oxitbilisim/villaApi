using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class TakvimRezarvasyonDtoQ
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
    }
}