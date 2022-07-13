using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class VillaImageDetayDtoC 
    {
        public int? Id { get; set; }
        public int? VillaId { get; set; }
        public byte[] Image { get; set; }
    }
}