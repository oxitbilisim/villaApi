using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{
    public class Ilce : BaseSimpleModel
    {
        public Ilce()
        {
            Villa = new();
        }
      
        public string Ad { get; set; }
        public int IlId { get; set; }
        public virtual Il Il { get; set; }
        public virtual HashSet<Villa> Villa { get; set; } 
    }
}