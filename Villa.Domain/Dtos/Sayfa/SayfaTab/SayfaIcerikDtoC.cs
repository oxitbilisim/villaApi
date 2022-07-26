using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class SayfaIcerikDtoC 
    {
        public int? Id { get; set; }
        public int SayfaId { get; set; }
        public string Icerik { get; set; }
        public string VideoUrl { get; set; }
        public byte[]? Image { get; set; } 
    }
}