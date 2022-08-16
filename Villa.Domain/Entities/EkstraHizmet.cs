using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class EkstraHizmet : BaseSimpleModel
    {
        public EkstraHizmet()
        {
            RezervasyonEktraHizmet = new();
        }

        public string Ad { get; set; }
        public virtual HashSet<RezervasyonEkstraHizmet> RezervasyonEktraHizmet { get; set; }

    }
}