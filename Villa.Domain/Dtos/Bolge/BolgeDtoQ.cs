namespace Villa.Domain.Dtos
{
    public class BolgeDtoQ
    {
        public int? Id { get; set; }
        public string Ad { get; set; }
        public bool? Active { get; set; }
        public string Baslik { get; set; }
      
        public string Url { get; set; }
        public string IlAd { get; set; }
        public int IlId { get; set; }
        public string? Etiket { get; set; }
        public byte[]? Image { get; set; }  
        
        public string Map { get; set; }
    }
}