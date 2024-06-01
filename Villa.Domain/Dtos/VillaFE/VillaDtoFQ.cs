using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class VillaDtoFQ
    {
        public int? Id { get; set; }
        public string? Ad { get; set; }
        public string? Bolge { get; set; }
        public string? KtbBelgeNo { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Mevki { get; set; }
        public string? Url { get; set; }
        public int? Kapasite { get; set; }
        public int? YatakOdaSayisi { get; set; }
        public int? OdaSayisi { get; set; }
        public int? BanyoSayisi { get; set; }
        
        public int? ImageId { get; set; }
        public int? discountRate { get; set; }
        public decimal? Fiyat { get; set; }
        public decimal? IndirimliFiyat { get; set; }
        public decimal? ToplamFiyat { get; set; }
        public decimal? IndirimliToplamFiyat { get; set; }
        public string? FiyatTuru { get; set; }
        public string? ParaBirimi { get; set; }
    }
}