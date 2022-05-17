using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class Il : BaseSimpleModel
    {
        public Il()
        {
            Ilce = new();
            Bolge = new();
        }

        public string Ad { get; set; }

        public string Kod { get; set; }
        public int Sira { get; set; }

        public virtual HashSet<Ilce> Ilce { get; set; }
        public virtual HashSet<Bolge> Bolge { get; set; }

    }
}