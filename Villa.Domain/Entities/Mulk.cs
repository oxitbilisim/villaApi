using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class Mulk : BaseSimpleModel
    {
        public Mulk()
        {
            Villa = new();
        }
        public string Ad { get; set; }
        public virtual HashSet<Villa> Villa { get; set; }
    }
}