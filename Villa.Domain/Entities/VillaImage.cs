using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaImage : BaseSimpleModel
    {
        public VillaImage()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        public string VideoUrl { get; set; }
        public int? SiraNo { get; set; }
        public string Url { get; set; }
        public bool? KapakResmi { get; set; } 
        
    }
}