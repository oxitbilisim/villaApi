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
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        
        public int OzellikId { get; set; }
        public virtual Ozellik Ozellik { get; set; }
        
    }
}