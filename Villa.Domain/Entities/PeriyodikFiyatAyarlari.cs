using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class PeriyodikFiyatAyarlari : BaseSimpleModel
    {
        public PeriyodikFiyatAyarlari()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        // public int ParaBirimiId { get; set; }
        // public virtual ParaBirimi ParaBirimi { get; set; }
        
        public int? Komisyon { get; set; }
        public int? Kapora { get; set; }
        public decimal? Depozito { get; set; }
        public decimal? TemizlikUcreti { get; set;} 
        public decimal? MinumumUcret { get; set; }
        public bool? KrediKartTahsilat { get; set;}
    }
}