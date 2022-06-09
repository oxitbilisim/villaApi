using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class VillaLokasyon : BaseSimpleModel
    {
        public VillaLokasyon()
        {
        }
        public int VillaId { get; set; }
        public virtual Villa Villa { get; set; }
        public int BolgeId { get; set; }
        public virtual Bolge Bolge { get; set; }
        public int IlceId { get; set; }
        public virtual Ilce Ilce { get; set; }
        public string Mevki { get; set; }
        public string Adres { get; set; }
        public string Map { get; set; }
        public string MrkUzaklik { get; set; }
        public string MarktUzaklik { get; set; }
        public string HvlUzaklik { get; set; }
        public string PljUzaklik { get; set; }
        public string RstUzaklik { get; set; }
        public string SglUzaklik { get; set; }
    }
}