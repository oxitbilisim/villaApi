using Villa.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Villa.Domain.Enum;

namespace Villa.Domain.Entities
{

    public class CollectionVillas  : BaseSimpleModel
    {
        public CollectionVillas()
        {
        }
        public int VillaId { get; set; }
        public int CollectionId { get; set; }
        public virtual Villa Villa { get; set; }
        public virtual Collections Collections { get; set; }
    }
}