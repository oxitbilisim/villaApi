using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Jemus.Domain;

namespace Jemus.Domain.Entities
{   public class SorumlulukAlani : BaseSimpleModel
    {
        public string Tanim { get; set; }

        public Guid? ParentSorumlulukAlaniId { get; set; }
        public virtual SorumlulukAlani ParentSorumlulukAlani { get; set; }

        public virtual ICollection<SorumlulukAlani> items { get; set; }
    }
}
