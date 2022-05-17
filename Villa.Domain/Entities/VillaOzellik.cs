using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaOzellik : BaseSimpleModel
    {
        public VillaOzellik()
        {
        }
        public Guid VillaId { get; set; }
        [ForeignKey("VillaId")]
        public virtual Villa Villa { get; set; }
        
        public Guid OzellikId { get; set; }
        [ForeignKey("OzellikId")]
        public virtual Ozellik Ozellik { get; set; }
        
    }
}