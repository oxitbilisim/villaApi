using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            VillaIcerik = new();
            VillaLokasyon = new();
            Rezervasyon = new();
        }
        
        public string Ad { get; set; }
        public string Baslik { get; set; }
        public string Url { get; set; }
        public int? Kapasite { get; set; }
        public int? YatakOdaSayisi { get; set; }
        public int? OdaSayisi { get; set; }
        public int? BanyoSayisi { get; set; }
        public int MulkId  { get; set; }
        public virtual Mulk Mulk { get; set; }
        public virtual HashSet<PeriyodikFiyat> PeriyodikFiyat { get; set; }
        public virtual HashSet<PeriyodikFiyatAyarlari> PeriyodikFiyatAyarlari { get; set; }
        public virtual HashSet<VillaImage> VillaImage { get; set; }
        public virtual HashSet<VillaKategori> VillaKategori { get; set; }
        public virtual HashSet<VillaOzellik> VillaOzellik { get; set; }
        public virtual HashSet<VillaGorunum> VillaGorunum { get; set; }
        public virtual HashSet<VillaGosterim> VillaGosterim { get; set; }
        public virtual HashSet<VillaSeo> VillaSeo { get; set; }
        public virtual HashSet<VillaIcerik> VillaIcerik { get; set; }
        public virtual HashSet<VillaLokasyon> VillaLokasyon { get; set; }
        public virtual HashSet<Rezervasyon> Rezervasyon { get; set; }
        
        
        
    }
}