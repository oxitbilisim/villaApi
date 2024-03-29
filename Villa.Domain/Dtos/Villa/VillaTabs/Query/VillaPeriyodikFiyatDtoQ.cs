using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Villa.Domain.Common;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Dtos
{
    public class VillaPeriyodikFiyatDtoQ 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }/*
        public DateTimeOffset Baslangic { get; set; }
        public DateTimeOffset Bitis { get; set; }*/
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EndDate { get; set; }
        public int ParaBirimiId { get; set; }
        public string ParaBirimiAd  { get; set; }

        public decimal Fiyat { get; set; }
       
        public FiyatTuru FiyatTuru { get; set; }
        
        public int Indirim { get; set; }
      
        public int EnAzKiralama { get; set; }
        
        public VillaPeriyodikFiyatDtoQ clone()
        {
            var result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<VillaPeriyodikFiyatDtoQ>(result);
        }
    }
}