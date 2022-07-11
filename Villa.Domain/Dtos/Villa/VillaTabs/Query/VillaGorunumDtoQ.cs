using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class VillaGorunumDtoQ
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public string OneCikanOzellik { get; set; }
        public string Etiket { get; set; }
        public string HavuzOzellik { get; set; }
        public List<VillaOzellikDtoQ> VillaOzellik { get; set; }
        public List<VillaGosterimDtoQ> VillaGosterim { get; set; }
        public List<VillaKategoriDtoQ> VillaKategori { get; set; }
        
    }
}