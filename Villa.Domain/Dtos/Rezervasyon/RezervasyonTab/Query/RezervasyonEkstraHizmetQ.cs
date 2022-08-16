namespace Villa.Domain.Dtos
{
    public class RezervasyonEkstraHizmetQ 
    {
        public int? Id { get; set; }
        public int RezervasyonId { get; set; }
        public int EkstraHizmetId { get; set; }
        public string EkstraHizmetAd { get; set; }
    }
}