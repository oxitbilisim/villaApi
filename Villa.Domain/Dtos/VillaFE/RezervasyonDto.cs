using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class RezervasyonDto
    {
        public RezervasyonDto()
        {
  
        }
        public int? Id { get; set; }
        public int VillaId  { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public RezervasyonDurum RezervasyonDurum { get; set; }

    }
}