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
        }
        public string Ad { get; set; }
    }
}