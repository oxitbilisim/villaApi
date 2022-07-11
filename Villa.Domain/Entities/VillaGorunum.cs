using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class VillaGorunum  : BaseSimpleModel
    {
        public VillaGorunum()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        
        public string OneCikanOzellik { get; set; }
        public string Etiket { get; set; }
        public string HavuzOzellik { get; set; }
        
        
    }
}