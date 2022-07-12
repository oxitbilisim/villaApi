using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaSahip : BaseSimpleModel
    {
        public VillaSahip()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        public string Sahip { get; set; }
        public string Telefon { get; set; }
        public string Iban { get; set; }
        public string Eposta { get; set; }
        public string Not { get; set; }
        
    }
}