using System;
using Villa.Domain.Enum;

namespace Villa.Domain.Dtos
{
    public class CollectionResponseDto
    {
        public VillaDtoFQ? villa { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        
    }
}