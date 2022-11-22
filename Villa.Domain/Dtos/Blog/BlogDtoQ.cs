using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class ParameterssDtoQ
    {
        public int? Id { get; set; }
        public string Baslik { get; set; }
        public string? AltBaslik { get; set; }
        public int? BlogKategoriId { get; set; }
        public string? BlogKategoriAd { get; set; }
        public string GirisYazisi { get; set; }
        public string Url { get; set; }
        public string? Etiket  { get; set ; }
        public byte[]? Image { get; set; } 
    }
}