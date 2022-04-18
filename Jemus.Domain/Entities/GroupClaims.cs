using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Jemus.Domain;

namespace Jemus.Entities.Models
{
    /// <summary>
    /// Grup Model Sınıfı
    /// </summary>
    public class GroupClaims : BaseSimpleModel
    {
        /// <summary>
        /// Grup Model Sınıfı Boş Oluşturucu
        /// </summary>
        public GroupClaims()
        {
        }

        public Guid GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        public Guid PermissionId { get; set; }
        [ForeignKey("PermissionId")]
        public virtual Permission Permission { get; set; }

    }
}
