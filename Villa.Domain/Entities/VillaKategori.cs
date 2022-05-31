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
        public virtual Villa Villa { get; set; }
        
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
        
    }
}