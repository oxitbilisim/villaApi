using System;

namespace Jemus.Domain
{
    public interface IBaseSimpleModel
    {
        Guid Id { get; set; }
        DateTime? CreateDate { get; set; }
     
    }
}
