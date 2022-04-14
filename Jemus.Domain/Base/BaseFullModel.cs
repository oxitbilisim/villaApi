using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Jemus.Domain
{
    public class BaseFullModel : IBaseFullModel
    {
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid? CreatorId { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Guid? EditorId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool Active { get; set; } = true;
    }
}
