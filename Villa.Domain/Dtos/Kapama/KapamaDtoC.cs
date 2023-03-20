using System;
using Newtonsoft.Json;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Dtos
{
    public class KapamaDtoC 
    {
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EndDate { get; set; }
       
        public RezervasyonDurum RezervasyonDurum { get; set; }
        public string Not { get; set; }
    }
}