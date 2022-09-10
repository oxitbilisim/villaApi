using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class KategoriDtoFQ
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Url { get; set; }
        public string IconName { get; set; }
        public int Toplam { get; set; }
        public byte[]? Image { get; set; }  
    }
}