using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain
{
    public class BaseSimpleModel : IBaseSimpleModel
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsDeleted { get; set; } = false;
        public bool Active { get; set; } = true;
        public DateTime? CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
