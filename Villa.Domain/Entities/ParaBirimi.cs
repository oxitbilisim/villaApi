using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class ParaBirimi : BaseSimpleModel
    {
        public ParaBirimi()
        {
        }
        public string Ad { get; set; }
        public virtual HashSet<PeriyodikFiyatAyarlari> PeriyodikFiyatAyarlari { get; set; } 
        public virtual HashSet<PeriyodikFiyat> PeriyodikFiyat{ get; set; } 
    }
}