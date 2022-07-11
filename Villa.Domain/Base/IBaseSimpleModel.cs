using System;

namespace Villa.Domain
{
    public interface IBaseSimpleModel
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
        bool Active { get; set; }
        DateTimeOffset? CreateDate { get; set; } 
        DateTimeOffset? EditDate { get; set; }
     
    }
}
