using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Villa.Domain;

namespace Villa.Domain.Entities
{   public class SorumlulukAlani : BaseSimpleModel
    {
        public SorumlulukAlani()
        {
            UserSorumlulukAlani = new();
        }
        public string Tanim { get; set; }

        public Guid? ParentSorumlulukAlaniId { get; set; }
        public virtual SorumlulukAlani ParentSorumlulukAlani { get; set; }

        public virtual HashSet<SorumlulukAlani> items { get; set; }
        public virtual HashSet<UserSorumlulukAlani> UserSorumlulukAlani { get; set; }
}
}
