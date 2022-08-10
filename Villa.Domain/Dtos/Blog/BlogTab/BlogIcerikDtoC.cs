using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class BlogIcerikDtoC 
    {
        public int? Id { get; set; }
        public int BlogId { get; set; }
        public int? BlogKategoriId { get; set; }
        public string Icerik { get; set; }
        public string VideoUrl { get; set; }
        public byte[]? Image { get; set; } 
        
    }
}