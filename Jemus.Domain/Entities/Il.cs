using Jemus.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jemus.Entities.Models
{

    public class Il : BaseSimpleModel
    {
        public Il()
        {
            Ilce = new();
        }

        public string Ad { get; set; }

        public string Kod { get; set; }
        public int Sira { get; set; }

        public virtual HashSet<Ilce> Ilce { get; set; }

    }
}