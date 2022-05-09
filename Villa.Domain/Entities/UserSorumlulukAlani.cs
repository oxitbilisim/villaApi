using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Villa.Domain;
using Villa.Domain.Auth;

namespace Villa.Domain.Entities
{   public class UserSorumlulukAlani : BaseSimpleModel
    { 
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public Guid SorumlulukAlaniId { get; set; }
        public virtual SorumlulukAlani SorumlulukAlani { get; set; }

    }
}
