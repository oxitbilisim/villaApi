using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain.Entities
{

    public class Villa : BaseSimpleModel
    {
        public Villa()
        {
            PeriyodikFiyat = new ();
            PeriyodikFiyatAyarlari = new();
            VillaImage = new();
            VillaKategori = new();
            VillaOzellik = new();
            VillaGorunum = new();
            VillaGosterim = new();
            VillaSeo = new();
        }
        
        public string Ad { get; set; }
        public string Baslik { get; set; }
        public string Url { get; set; }
        public int? Kapasite { get; set; }
        public int? YatakOdaSayisi { get; set; }
        public int? OdaSayisi { get; set; }
        public int? BanyoSayisi { get; set; }
        public string Icerik { get; set; }
        public int BolgeId { get; set; }
        [ForeignKey("BolgeId")]
        public virtual Bolge Bolge { get; set; }
        public int IlceId { get; set; }
     
        [ForeignKey("IlceId")]
        public virtual Ilce Ilce { get; set; }
        public string Mevki { get; set; }
        public string Adres { get; set; }
        public string Map { get; set; }
        public string MrkUzaklik { get; set; }
        public string HvlUzaklik { get; set; }
        public string PljUzaklik { get; set; }
        public string RstUzaklik { get; set; }
        public string SglUzaklik { get; set; }
        
        public virtual HashSet<PeriyodikFiyat> PeriyodikFiyat { get; set; }
        public virtual HashSet<PeriyodikFiyatAyarlari> PeriyodikFiyatAyarlari { get; set; }
        public virtual HashSet<VillaImage> VillaImage { get; set; }
        public virtual HashSet<VillaKategori> VillaKategori { get; set; }
        public virtual HashSet<VillaOzellik> VillaOzellik { get; set; }
        public virtual HashSet<VillaGorunum> VillaGorunum { get; set; }
        public virtual HashSet<VillaGosterim> VillaGosterim { get; set; }
        public virtual HashSet<VillaSeo> VillaSeo { get; set; }
        
        
        
    }
}