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
        public DateOnly Baslangic { get; set; }

        public DateOnly Bitis { get; set; }
        public string MusteriAdSoyad { get; set; }
        
        public int? MSYetiskin { get; set; }
        public int? MSCocuk { get; set; }
        public int? MSBebek { get; set; }
        public string TelefonNo { get; set; }
        public string Email { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }
        public string Not { get; set; }
        
     

        
        
        
    }
}