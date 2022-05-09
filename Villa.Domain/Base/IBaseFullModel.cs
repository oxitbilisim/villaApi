using System;

namespace Villa.Domain
{
    public interface IBaseFullModel
    {
        Guid Id { get; set; }
        DateTime? CreateDate { get; set; }
        Guid? CreatorId { get; set; }
        DateTime? EditDate { get; set; }
        DateTime? DeleteDate { get; set; }
        Guid? EditorId { get; set; }
        bool IsDeleted { get; set; }
        bool Active { get; set; }
    }
}
