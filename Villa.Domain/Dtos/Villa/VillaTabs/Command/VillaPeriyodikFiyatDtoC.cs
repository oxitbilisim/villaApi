using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class VillaPeriyodikFiyatDtoC 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public DateTime Baslangic { get; set; }

        public DateTime Bitis { get; set; }

        public decimal Fiyat { get; set; }
       
        public FiyatTuru FiyatTuru { get; set; }
        
        public int Indirim { get; set; }
      
        public int EnAzKiralama { get; set; }
    }
}