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
        public HashSet<VillaOzellikDtoQ> VillaOzellik { get; set; }
        public HashSet<VillaGosterimDtoQ> VillaGosterim { get; set; }
        public HashSet<VillaKategoriDtoQ> VillaKategori { get; set; }
        
    }
}