using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class KategoriDtoQ
    {
        public int? Id { get; set; }

        public int VillaKategoriAd { get; set; }

        public string Ad { get; set; }

        public string Baslik { get; set; }
      
        public string Url { get; set; }

        public KategoriTipi Tipi { get; set; }   
        public string? Etiket { get; set; }
        public byte[] Image { get; set; }  
    }
}