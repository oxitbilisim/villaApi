namespace Villa.Domain.Dtos
{
    public class VillaImageDtoQ 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public byte[] Image { get; set; }
        public string VideoUrl { get; set; }
        public int SiraNo { get; set; }
        public bool Url { get; set; }
    }
}