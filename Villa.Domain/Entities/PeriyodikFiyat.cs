using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using Villa.Domain.Enum;
using Villa.Domain.Utilities;

namespace Villa.Domain.Entities
{

    public class PeriyodikFiyat : BaseSimpleModel
    {
        public PeriyodikFiyat()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        public int ParaBirimiId { get; set; }
        public virtual ParaBirimi ParaBirimi { get; set; }
        
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly StartDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly EndDate { get; set; }

        public decimal Fiyat { get; set; }
       
        public FiyatTuru FiyatTuru { get; set; }
        
       public int Indirim { get; set; }
      
        public int EnAzKiralama { get; set; }
        
    }
}