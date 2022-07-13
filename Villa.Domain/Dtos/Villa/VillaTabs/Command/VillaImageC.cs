using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class VillaImageDtoC 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public List<byte[]> Image { get; set; }
        public string VideoUrl { get; set; }
        public int SiraNo { get; set; }
        public bool Url { get; set; }
    }
}