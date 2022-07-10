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

    public class RezervasyonMisafir : BaseSimpleModel
    {
        public RezervasyonMisafir()
        {
  
        }
        public int RezervasyonId  { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }

        public string MisafirAdSoyad { get; set; }
        
        public string Yas { get; set; }
        public string TcNo { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        
    }
}