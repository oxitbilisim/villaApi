using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class EtiketDetay : BaseSimpleModel
    {
        public EtiketDetay()
        {
        }
        
        public Guid EtiketId { get; set; }
        [ForeignKey("EtiketId")]
        public virtual Etiket Etiket { get; set; }
        
        public EtiketAdres EtiketTipi { get; set; }
        public Guid AdresId { get; set; }
    }
}