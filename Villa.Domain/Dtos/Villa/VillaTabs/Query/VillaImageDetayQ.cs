namespace Villa.Domain.Dtos
{
    public class VillaImageDetayDtoQ 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public byte[] Image { get; set; }
    }
}