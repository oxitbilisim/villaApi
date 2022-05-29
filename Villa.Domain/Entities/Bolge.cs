using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class Bolge : BaseSimpleModel
    {
        public Bolge()
        {
            Villa = new();
        }
 
        public string Ad { get; set; }

        public string Baslik { get; set; }
      
        public string? Url { get; set; }

        public int IlId { get; set; }
        public virtual Il Il { get; set; }
        
        public byte[]? Image { get; set; }  
        
        public string? Map { get; set; }
        
        [NotMapped]
        public virtual HashSet<Villa> Villa { get; set; } 
        
    }
}