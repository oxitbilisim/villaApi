using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaImageDetay : BaseSimpleModel
    {
        public VillaImageDetay()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        public byte[] Image { get; set; }
        
        public bool? KapakResmi { get; set; } 
    }
}