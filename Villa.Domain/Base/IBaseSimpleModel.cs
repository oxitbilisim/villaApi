using System;

namespace Villa.Domain
{
    public interface IBaseSimpleModel
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
        bool Active { get; set; }
        DateTime? CreateDate { get; set; } 
        DateTime? EditDate { get; set; }
     
    }
}
