using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Domain.Dtos
{
    public class SorumlulukAlaniDto
    {
        public SorumlulukAlaniDto()
        {
            children = new List<SorumlulukAlaniDto>();
        }
        public string title { get; set; }
        public Guid value { get; set; }
        public Guid key { get; set; }
        //public Guid? ParentSorumlulukAlaniId { get; set; }
        public List<SorumlulukAlaniDto> children { get; set; }
    }

}
