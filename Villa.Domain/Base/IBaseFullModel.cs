using System;

namespace Villa.Domain
{
    public interface IBaseFullModel
    {
        int Id { get; set; }
        DateTime? CreateDate { get; set; }
        int? CreatorId { get; set; }
        DateTime? EditDate { get; set; }
        DateTime? DeleteDate { get; set; }
        int? EditorId { get; set; }
        bool IsDeleted { get; set; }
        bool Active { get; set; }
    }
}
