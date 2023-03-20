using System;
using Newtonsoft.Json;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Dtos
{
    public class VillaPeriyodikFiyatDtoC 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }
        public int ParaBirimiId { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EndDate { get; set; }

        public decimal Fiyat { get; set; }
       
        public FiyatTuru FiyatTuru { get; set; }
        
        public int Indirim { get; set; }
      
        public int EnAzKiralama { get; set; }
    }
}