using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class CostCalculateDto
    {
        public CostCalculateDto()
        {
  
        }
        public string Start { get; set; }
        public string End { get; set; }
        public decimal Total { get; set; }
        
    }
}