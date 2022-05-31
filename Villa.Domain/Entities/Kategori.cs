using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class Kategori : BaseSimpleModel
    {
        public Kategori()
        {
        }

        public string Ad { get; set; }

        public string Baslik { get; set; }
 
        public string? Etiket { get; set; }
      
        public string Url { get; set; }

        public KategoriTipi Tipi { get; set; }   
        
        public byte[] Image { get; set; }  
        public virtual HashSet<VillaKategori> VillaKategori { get; set; }
        
    }
}