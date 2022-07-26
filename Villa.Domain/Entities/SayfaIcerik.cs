using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class SayfaIcerik : BaseSimpleModel
    {
        public SayfaIcerik()
        {
        }
        public int SayfaId { get; set; }
        public virtual Sayfa Sayfa { get; set; }
        public string Icerik { get; set; }
        public string VideoUrl { get; set; }
        public byte[]? Image { get; set; } 
    }
}