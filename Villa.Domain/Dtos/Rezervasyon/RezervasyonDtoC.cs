using System;
using Newtonsoft.Json;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Dtos
{
    public class RezervasyonDtoC 
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EndDate { get; set; }
        public string MusteriAdSoyad { get; set; }
        public DateTimeOffset? CreateDate { get; set; } = DateTimeOffset.Now;

        public int? MSYetiskin { get; set; }
        public int? MSCocuk { get; set; }
        public int? MSBebek { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
        public string Not { get; set; }
    }
}