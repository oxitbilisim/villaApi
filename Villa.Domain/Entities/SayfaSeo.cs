using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class SayfaSeo  : BaseSimpleModel
    {
        public SayfaSeo()
        {
        }
        public int SayfaId { get; set; }
        public virtual Sayfa Sayfa { get; set; }
        
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string AnahtarKelime { get; set; }
        public string HtmlMetaEtiket { get; set; }
    }
}