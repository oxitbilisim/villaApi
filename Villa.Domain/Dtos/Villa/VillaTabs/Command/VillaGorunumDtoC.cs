using System.Collections.Generic;

namespace Villa.Domain.Dtos
{
    public class VillaGorunumDtoC 
    {
        public int? Id { get; set; }
        public int VillaId { get; set; }
        public string OneCikanOzellik { get; set; }
        public string Etiket { get; set; }
        public string HavuzOzellik { get; set; }
        public List<VillaOzellikDtoC> VillaOzellik { get; set; }
        public List<VillaKategoriDtoC> VillaKategori { get; set; }
        public List<VillaGosterimDtoC> VillaGosterim { get; set; }
    }
}