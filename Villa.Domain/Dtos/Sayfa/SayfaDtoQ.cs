using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class SayfaDtoQ
    {
        public int? Id { get; set; }
        public string Ad { get; set; }
        public string Baslik { get; set; }
        public string Url { get; set; }
        public Menus Menu  { get; set ; }
        public byte[]? Image { get; set; } 
    }
}