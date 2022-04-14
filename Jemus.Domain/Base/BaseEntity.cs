using System.ComponentModel.DataAnnotations;

namespace Jemus.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
