using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class VillaImageDtoC 
    {
        public int? Id { get; set; }
        public int? SiraNo { get; set; }
        
        public int VillaId { get; set; }
        public string VideoUrl { get; set; }
        public string Url { get; set; }
        
        public List<VillaImageDetayDtoC> ImageList { get; set; }
    }
}