using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

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
        public DateTimeOffset Baslangic { get; set; }
        
        public DateTimeOffset Bitis { get; set; }

        public decimal Fiyat { get; set; }
       
        public FiyatTuru FiyatTuru { get; set; }
        
       public int Indirim { get; set; }
      
        public int EnAzKiralama { get; set; }
        
    }
}