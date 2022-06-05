namespace Villa.Domain.Dtos
{
    public class VillaLokasyonDtoQ 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public int BolgeId { get; set; }
        public int? IlceId { get; set; }
        public string Mevki { get; set; }
        public string Adres { get; set; }
        public string Map { get; set; }
        public string MrkUzaklik { get; set; }
        public string HvlUzaklik { get; set; }
        public string PljUzaklik { get; set; }
        public string RstUzaklik { get; set; }
        public string SglUzaklik { get; set; }
    }
}