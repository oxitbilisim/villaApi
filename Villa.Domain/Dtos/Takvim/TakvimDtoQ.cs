using System;
using Newtonsoft.Json;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Dtos
{
    public class TakvimDtoQ
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly Tarih { get; set; }
        public TakvimYarimGun TakvimYarimGun { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
    }
}