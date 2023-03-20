using System;
using Newtonsoft.Json;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Dtos
{
    public class KapamaDtoQ
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        public string VillaAd  { get; set; }

        /*public DateTimeOffset Baslangic { get; set; }
        public DateTimeOffset Bitis { get; set; }*/
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EndDate { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }

        public Boolean OpenState { get; set; }
        public string Not { get; set; }
    }
}