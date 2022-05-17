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
        public Guid VillaId { get; set; }
        [ForeignKey("VillaId")]
        public virtual Villa Villa { get; set; }
        
        public DateTime Baslangic { get; set; }

        public DateTime Bitis { get; set; }

        public decimal Fiyat { get; set; }
       
        public FiyatTuru FiyatTuru { get; set; }
        
       public int Indirim { get; set; }
      
        public int EnAzKiralama { get; set; }
        
    }
}