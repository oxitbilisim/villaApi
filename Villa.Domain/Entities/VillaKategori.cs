using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaKategori : BaseSimpleModel
    {
        public VillaKategori()
        {
        }
        public int VillaId { get; set; }
        [ForeignKey("VillaId")]
        public virtual Villa Villa { get; set; }
        
        public int KategorId { get; set; }
        [ForeignKey("KategorId")]
        public virtual Kategori Kategori { get; set; }
        
    }
}