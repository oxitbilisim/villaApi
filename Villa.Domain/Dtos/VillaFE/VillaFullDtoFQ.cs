using System.Collections.Generic;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class VillaFullDtoFQ
    {
        public int? Id { get; set; }
        // public string Ad { get; set; }
        // public string Il { get; set; }
        // public string Ilce { get; set; }
        // public string Mevki { get; set; }
        
        public VillaDtoFQ Villa { get; set; }
        public List<VillaImageDetayDtoQ> Images { get; set; }
        public VillaIcerikDtoQ Icerik { get; set; }
        public VillaLokasyonDtoQ Lokasyon { get; set; }
        public VillaSeoDto Seo { get; set; }
        public List<VillaKategoriDtoQ> Kategori { get; set; }
        public List<VillaOzellikDtoQ> Ozellik { get; set; }
        public VillaGorunumDtoQ Gorunum { get; set; }
        public List<VillaPeriyodikFiyatDtoQ> PeriyodikFiyat { get; set; }
        public List<VillaPeriyodikFiyatAyarlariDtoQ> PeriyodikFiyatAyarlari { get; set; }
        // public string Url { get; set; }
        // public int? Kapasite { get; set; }
        // public int? YatakOdaSayisi { get; set; }
        // public int? OdaSayisi { get; set; }
        // public int? BanyoSayisi { get; set; }
        // public byte[]? Image { get; set; }
        // public decimal? Fiyat { get; set; }
        // public string? FiyatTuru { get; set; }
        // public string? ParaBirimi { get; set; }
    }
}