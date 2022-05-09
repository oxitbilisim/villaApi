using System;

namespace Villa.Domain
{
    public interface IBaseSimpleModel
    {
        Guid Id { get; set; }
        DateTime? CreateDate { get; set; }
     
    }
}
