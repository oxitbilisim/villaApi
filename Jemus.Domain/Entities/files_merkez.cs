

using System;

using Jemus.Domain;
using Jemus.Domain.Enum;

namespace Jemus.Entities.Models
{
    public class files_merkez
    {
        public long clientid { get; set; }
        public string filepath { get; set; }
        public string? name { get; set; }
        public string? plaka { get; set; }
        public string? clientname { get; set; }
        public string? yonbilgisi { get; set; }
        public string? ulke { get; set; }
        public string? tip { get; set; }
        public string? marka { get; set; }
        public string? renk { get; set; }
        public string? plakakoordinati { get; set; }
        public string? hiz { get; set; }
        public string? detectionnumber { get; set; }
        public string? confidence { get; set; }
        public string? enlem { get; set; }
        public string? boylam { get; set; }
        public string? plakaokumasayisi { get; set; }
        public string? dogrulukorani { get; set; }
        public DateTime datetime { get; set; }
        public bool? isprocessed { get; set; }
        public long gedoid { get; set; }
        public string? result { get; set; }
        public string? aciklama { get; set; }
        public string? tescilyil { get; set; }
        public string? tescilrenk { get; set; }
        public string? tescilmarka { get; set; }
        public string? tescilcinsi { get; set; }
        public string? tescilmodel { get; set; }
        public string? tesciltip { get; set; }
        public string? tescilsinif { get; set; }
        public Nullable<DateTime> tescilzamani { get; set; }
        public SakincaDurumu? sakincadurumu { get; set; }
        public IslemTipi? islemtipi { get; set; }
        public string? il { get; set; }
        public string? ptsyonu { get; set; }


    }
}
