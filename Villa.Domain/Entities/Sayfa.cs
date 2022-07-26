using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class Sayfa : BaseSimpleModel
    {
        public Sayfa()
        {
        }

        public string Ad { get; set; }
        public string Baslik { get; set; }
        public string Url { get; set; }
        public Menus Menu  { get; set ; }
        public byte[]? Image { get; set; } 
        public virtual HashSet<SayfaIcerik> SayfaIcerik { get; set; } 
        public virtual HashSet<SayfaSeo> SayfaSeo { get; set; } 

        
    }
}