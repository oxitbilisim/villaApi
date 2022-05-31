using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaIcerik : BaseSimpleModel
    {
        public VillaIcerik()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        public string Icerik { get; set; }

        
    }
}