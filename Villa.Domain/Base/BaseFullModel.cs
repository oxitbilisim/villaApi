using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Villa.Domain
{
    public class BaseFullModel : IBaseFullModel
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CreatorId { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? EditorId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool Active { get; set; } = true;
    }
}
