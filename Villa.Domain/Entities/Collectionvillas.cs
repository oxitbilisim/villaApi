
using System;

namespace Villa.Domain.Entities
{

    public class CollectionVillas  : BaseSimpleModel
    {
        public CollectionVillas()
        {
        }
        public int VillaId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int CollectionsId { get; set; }
        public virtual Villa Villa { get; set; }
        public virtual Collections Collections { get; set; }
    }
}