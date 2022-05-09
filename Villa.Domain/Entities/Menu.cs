using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Villa.Domain;

namespace Villa.Domain.Entities
{
    public class Menu : BaseSimpleModel
    {
        [MaxLength(200)]
        public string Label { get; set; }
        [MaxLength(100)]
        public string Icon { get; set; }
        [MaxLength(200)]
        public string RouteLink { get; set; }

        public Guid? ParentMenuId { get; set; }
        public virtual Menu ParentMenu { get; set; }

        public virtual ICollection<Menu> items { get; set; }
        public virtual ICollection<MenuPermission> MenuPermission { get; set; }
    }
}
