using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class VillaImageDtoQ 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public List<VillaImageDetayDtoQ> ImageList { get; set; }
        public string VideoUrl { get; set; }
        public int SiraNo { get; set; }
        public string Url { get; set; }
    }
}