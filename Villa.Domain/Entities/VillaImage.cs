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
        public Guid VillaId { get; set; }
        [ForeignKey("VillaId")]
        public virtual Villa Villa { get; set; }
        
        public string VideoUrl { get; set; }
        public int SiraNo { get; set; }
        public bool Url { get; set; }
        
    }
}