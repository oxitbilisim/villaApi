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

    public class RezervasyonEkstraHizmet : BaseSimpleModel
    {
        public RezervasyonEkstraHizmet()
        {
  
        }
        public int RezervasyonId  { get; set; }
        public virtual Rezervasyon Rezervasyon { get; set; }
        public int EkstraHizmetId  { get; set; }
        public virtual EkstraHizmet EkstraHizmet { get; set; }
        
        
    }
}