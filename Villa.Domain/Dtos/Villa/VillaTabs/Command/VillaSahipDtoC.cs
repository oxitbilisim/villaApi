namespace Villa.Domain.Dtos
{
    public class VillaSahipDtoC 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public string Sahip { get; set; }
        public string Telefon { get; set; }
        public string Iban { get; set; }
        public string Eposta { get; set; }
        public string Not { get; set; }
    }
}