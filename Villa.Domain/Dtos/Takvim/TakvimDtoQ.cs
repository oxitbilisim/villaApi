using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class TakvimDtoQ
    {
        public DateTimeOffset Tarih { get; set; }
        public TakvimYarimGun TakvimYarimGun { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
    }
}