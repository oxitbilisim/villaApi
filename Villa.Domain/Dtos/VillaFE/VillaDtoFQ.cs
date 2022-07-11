using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class VillaDtoFQ
    {
        public int? Id { get; set; }
        public string Ad { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mevki { get; set; }
        public string Url { get; set; }
        public int? Kapasite { get; set; }
        public int? YatakOdaSayisi { get; set; }
        public int? OdaSayisi { get; set; }
        public int? BanyoSayisi { get; set; }
        public byte[]? Image { get; set; }
        public decimal? Fiyat { get; set; }
        public string? FiyatTuru { get; set; }
        public string? ParaBirimi { get; set; }
    }
}