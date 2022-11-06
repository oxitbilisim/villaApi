using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class Rezervasyon : BaseSimpleModel
    {
        public Rezervasyon()
        {
  
        }
        public int VillaId  { get; set; }
        public virtual Villa Villa { get; set; }
        
        public DateTimeOffset Baslangic { get; set; }

        public DateTimeOffset Bitis { get; set; }
        public string MusteriAdSoyad { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public int? MSYetiskin { get; set; }
        public int? MSCocuk { get; set; }
        public int? MSBebek { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public bool? OpenState { get; set; } = false;
        public RezervasyonDurum RezervasyonDurum { get; set; }
        public virtual ICollection<RezervasyonMaliBilgi> RezervasyonMaliBilgi { get; set; }
        public string Not { get; set; }
    }
}