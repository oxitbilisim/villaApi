namespace Villa.Domain.Dtos
{
    public class VillaDtoFQ
    {
        public int? Id { get; set; }
        public string Ad { get; set; }
        public string Baslik { get; set; }
        public string MulkAd { get; set; }
        public int? MulkId { get; set; }
        public string Url { get; set; }
        public int? Kapasite { get; set; }
        public int? YatakOdaSayisi { get; set; }
        public int? OdaSayisi { get; set; }
        public int? BanyoSayisi { get; set; }
        public byte? Image { get; set; }
        public decimal PeriyodikFiyatFiyat { get; set; }
        public string PeriyodikFiyatFiyatTuru { get; set; }
        public string PeriyodikFiyatParaBirimi { get; set; }
        
    }
}