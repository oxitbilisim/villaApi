using System.ComponentModel.DataAnnotations;

namespace Villa.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
